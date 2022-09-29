﻿using Application.Recipes.Exceptions;
using Application.Users.Exceptions;
using Domain.Foundation;
using Domain.Models.Recipes;
using Domain.Models.Users;

namespace Application.Recipes
{
    public class RecipeService : IRecipeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RecipeService(IUnitOfWork repository)
        {
            _unitOfWork = repository;
        }

        private Recipe ChangeRecipeOwner(Recipe recipe)
        {
            Recipe changedUserRecipe = recipe;
            changedUserRecipe.Owner = _unitOfWork.UserRepository.FirstOrDefault(user => user.Login == recipe.Owner.Login);
            if (changedUserRecipe.Owner == null)
                throw new UserAuthException(recipe.Owner.Login, "");
            changedUserRecipe.OwnerId = changedUserRecipe.Owner.Id;
            return changedUserRecipe;
        }

        public Recipe Add(Recipe recipe)
        {
            _unitOfWork.RecipeRepository.Add(ChangeRecipeOwner(recipe));
            _unitOfWork.Commit();
            return recipe;
        }

        public Recipe ChangeRecipe(Recipe recipe)
        {
            Recipe changedRecipe = _unitOfWork.RecipeRepository.FirstOrDefault(e => (e.Owner == recipe.Owner && e.Title == recipe.Title));
            changedRecipe.DescriptionText = recipe.DescriptionText;
            changedRecipe.TimeRemaining = recipe.TimeRemaining;
            changedRecipe.RecipeTags = recipe.RecipeTags;
            changedRecipe.Steps = recipe.Steps;
            changedRecipe.Ingridients = recipe.Ingridients;
            changedRecipe.CountPersons = recipe.CountPersons;
            
            _unitOfWork.Commit();

            return recipe;
        }

        public List<Recipe> GetAllRecipes()
        {
            return _unitOfWork.RecipeRepository.GetAll();
        }

        public List<Recipe> GetAllRecipesOfUser(User user)
        {
            return (List<Recipe>)_unitOfWork.RecipeRepository.Where(r => r.Owner == user);
        }

        public List<Recipe> GetByContainigName(string name)
        {
            return (List<Recipe>)_unitOfWork.RecipeRepository.Where(r => r.Title.Contains(name));
        }

        public Recipe GetRecypeById(long id)
        {
            Recipe findedRecipe = _unitOfWork.RecipeRepository.FirstOrDefault(r => r.Id == id);
            if (findedRecipe == null)
                throw new RecipeNotFoundException("Рецепт не найден");
            return findedRecipe;
        }

        public Recipe GetTopRecipe()
        {
            Recipe result = _unitOfWork.RecipeRepository.GetQuery().OrderByDescending(r => r.Likes.Result).FirstOrDefault();
            return result;
        }
    }
}
