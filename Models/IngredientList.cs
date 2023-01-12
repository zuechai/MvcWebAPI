namespace dotnet_api.Models
{
    public class IngredientList
    {
        public long Id { get; set; }

        public string? Measurement { get; set; }

        public ICollection<Ingredient>? Ingredients { get; set; }

        public long RecipeId { get; set; }
        public Recipe? Recipe { get; set; }
    }
}