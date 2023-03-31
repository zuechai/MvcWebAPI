using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace dotnet_api.Models;

[Index(nameof(Name), IsUnique = true)]
public class Ingredient
{
    [Required]
    public long Id { get; set; }

    public string? Name { get; set; }
}
