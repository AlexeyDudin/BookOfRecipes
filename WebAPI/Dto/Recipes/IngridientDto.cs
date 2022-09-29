using System.Runtime.Serialization;

namespace WebAPI.Dto.Recipes
{
    [DataContract]
    public class IngridientDto
    {
        public string Name { get; set; }
        public string Products { get; set; }
    }
}