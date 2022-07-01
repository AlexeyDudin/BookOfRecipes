using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Recipes
{
    public class Recipe
    {
        private int _id;
        private string _name;
        private string _shortInfo;
        private List<Tags> _tags;
        private int _timeRemaining;
        private int _countPersons;
        private List<Ingridient> _ingridients;
        private List<Step> _steps;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string ShortInfo { get => _shortInfo; set => _shortInfo = value; }
        public List<Tags> Tags { get => _tags; set => _tags = value; }
        public int TimeRemaining { get => _timeRemaining; set => _timeRemaining = value; }
        public int CountPersons { get => _countPersons; set => _countPersons = value; }
        public List<Ingridient> Ingridients { get => _ingridients; set => _ingridients = value; }
        public List<Step> Steps { get => _steps; set => _steps = value; }
    }
}
