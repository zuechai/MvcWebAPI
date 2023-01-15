using System.ComponentModel.DataAnnotations;

namespace dotnet_api.Models;

public class User
{
    [Required]
    public long Id { get; set; }

    [Required]
    public string? Username { get; set; }

    [Required]
    public string? FirstName { get; set; }

    [Required]
    public string? LastName { get; set; }

    [Required]
    public string? Email { get; set; }

    [Timestamp]
    public DateTime? CreatedAt { get; set; }

    public List<Recipe>? Recipes { get; set; }
}
