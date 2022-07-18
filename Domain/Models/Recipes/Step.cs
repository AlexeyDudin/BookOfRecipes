namespace Domain.Models.Recipes
{
    public class Step
    {
        public long Id { get; set; }
        public long RecipeId { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
    }
}