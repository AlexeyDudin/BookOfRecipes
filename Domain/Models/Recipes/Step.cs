namespace Domain.Models.Recipes
{
    public class Step
    {
        public virtual long Id { get; set; }
        public virtual long RecipeId { get; set; }
        public virtual int Number { get; set; }
        public virtual string Description { get; set; }
    }
}