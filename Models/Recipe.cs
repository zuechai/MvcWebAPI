using System.ComponentModel.DataAnnotations;

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
    public User? User { get; set; }

    public List<IngredientList>? IngredientLists { get; set; }
}
