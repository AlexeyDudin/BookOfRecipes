﻿using System.Runtime.Serialization;

namespace WebAPI.Dto.Recipes
{
    [DataContract]
    public class RecipeDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public UserDto Owner { get; set; }
        public string DescriptionText { get; set; }
        public List<TagsDto> Tags { get; set; }
        public int TimeRemaining { get; set; }
        public int CountPersons { get; set; }
        public List<IngridientDto> Ingridients { get; set; }
        public List<StepDto> Steps { get; set; }
        public long LikeCount { get; set; }
        public RecipePhotoDto RecipePhoto { get; set; }
    }
}
