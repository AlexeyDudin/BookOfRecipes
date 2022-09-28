using System.Runtime.Serialization;
using System.Xml.Linq;

namespace WebAPI.Dto.Recipes
{
    [DataContract]
    public class StepDto
    {
        [DataMember(Name = "count")]
        public int Number { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}