using dotnet_api.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_api.Data;

public class RecipeContext : DbContext
{
    public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
    {
    }

    public DbSet<Recipe> Recipes => Set<Recipe>();
    public DbSet<Ingredient> Ingredients => Set<Ingredient>();
    public DbSet<IngredientList> IngrdientsLists => Set<IngredientList>();
    public DbSet<Method> Methods => Set<Method>();
    public DbSet<User> Users => Set<User>();
}