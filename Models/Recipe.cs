using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_api.Models;

public class Recipe
{
    [Required]
    public long Id { get; set; }

    [Required]
    public string? Title { get; set; }

    public string? ImagePath { get; set; }

    [Required]
    public long UserId { get; set; }

    [Required]
    public ICollection<IngredientList>? Ingredients { get; set; }
}
