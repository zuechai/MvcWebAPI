using System.ComponentModel.DataAnnotations;

namespace dotnet_api.Models
{
    public class Ingredient
    {
        [Required]
        public long Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public ICollection<IngredientList>? IngredientLists { get; set; }
    }
}