using System.Runtime.Serialization;

namespace WebAPI.Dto.Recipes
{
    [DataContract]
    public class TagsDto
    {
        [DataMember(Name = "text")]
        public string Name { get; set; }
    }
}