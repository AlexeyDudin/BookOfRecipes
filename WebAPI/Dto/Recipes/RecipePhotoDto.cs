using System.Runtime.Serialization;
using System.Xml.Linq;

namespace WebAPI.Dto.Recipes
{
    [DataContract]
    public class RecipePhotoDto
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "url")]
        public string Url { get; set; }
    }
}
