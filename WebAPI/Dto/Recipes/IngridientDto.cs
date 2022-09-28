using System.Runtime.Serialization;

namespace WebAPI.Dto.Recipes
{
    [DataContract]
    public class IngridientDto
    {
        [DataMember(Name = "text")]
        public string Name { get; set; }
        [DataMember(Name = "count")]
        public string Products { get; set; }
    }
}