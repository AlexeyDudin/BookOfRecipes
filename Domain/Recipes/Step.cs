namespace Domain.Recipes
{
    public class Step
    {
        private int _id;
        private int _stepCount;
        private string _about;

        public int Id { get => _id; set => _id = value; }
        public int StepCount { get => _stepCount; set => _stepCount = value; }
        public string About { get => _about; set => _about = value; }
    }
}