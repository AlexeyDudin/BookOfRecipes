using System.Runtime.Serialization;
using System.Xml.Linq;

namespace WebAPI.Dto.Recipes
{
    [DataContract]
    public class StepDto
    {
        public int Number { get; set; }
        public string Description { get; set; }
    }
}