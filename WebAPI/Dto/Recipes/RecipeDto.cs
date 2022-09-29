using System.Runtime.Serialization;

namespace WebAPI.Dto.Recipes
{
    [DataContract]
    public class RecipeDto
    {
        //[DataMember(Name = "id")]
        public long Id { get; set; }
        //[DataMember(Name = "title")]
        public string Title { get; set; }
        //[DataMember(Name = "owner")]
        public UserDto Owner { get; set; }
        //[DataMember(Name = "text")]
        public string DescriptionText { get; set; }
        //[DataMember(Name = "tags")]
        public List<TagsDto> Tags { get; set; }
        //[DataMember(Name = "timer")]
        public int TimeRemaining { get; set; }
        //[DataMember(Name = "persons")]
        public int CountPersons { get; set; }
        //[DataMember(Name = "ingridients")]
        public List<IngridientDto> Ingridients { get; set; }
        //[DataMember(Name = "step")]
        public List<StepDto> Steps { get; set; }
        //[DataMember(Name = "likeCount")]
        public long LikeCount { get; set; }
        //[DataMember(Name = "imagePath")]
        public RecipePhotoDto RecipePhoto { get; set; }
    }
}
