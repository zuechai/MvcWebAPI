using System.ComponentModel.DataAnnotations;

namespace dotnet_api.Models
{
    public class User
    {
        public long Id { get; set; }

        public string? Username { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public List<Recipe>? Recipes { get; set; }
    }
}