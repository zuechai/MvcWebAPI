using System.ComponentModel.DataAnnotations;

namespace dotnet_api.Models;

public class Method
{
    [Required]
    public long Id { get; set; }

    [Required]
    public int? StepNumber { get; set; }

    [Required]
    public string? Instruction { get; set; }

    [Required]
    public long RecipeId { get; set; }
    [Required]
    public Recipe? Recipe { get; set; }

}