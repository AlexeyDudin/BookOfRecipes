import { HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Recipe } from '../Entityes/Recipe';
import { User } from '../Entityes/user';
import { BaseService } from './base.service';
import { StorageService } from './storage.service';

@Injectable({
  providedIn: 'root'
})
export class ResipeService {

  constructor(private baseService: BaseService, private storage: StorageService) { }

  getRecipeById(recipeId: number) {
    return this.baseService.sendPost('/api/recipe/byId', recipeId);
  }

  getUserRecypes(user: User) {
    
  }

  getTopRecipe() {
    return this.baseService.sendGet("/api/recipe/top");
  }

  getRecipes() {
    return this.baseService.sendGet('/api/recipe/all');
  }

  saveRecipe(recipe: Recipe) {
    return this.baseService.sendPostWithAuthHeader("/api/recipe", recipe, this.storage.getToken());
  }
}
