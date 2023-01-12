using System.ComponentModel.DataAnnotations;

namespace dotnet_api.Models;

public class IngredientList
{
    [Required]
    public long Id { get; set; }

    [Required]
    public string? Measurement { get; set; }

    [Required]
    public ICollection<Ingredient>? Ingredients { get; set; }

    [Required]
    public long RecipeId { get; set; }
    public Recipe? Recipe { get; set; }
}