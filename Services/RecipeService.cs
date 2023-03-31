using dotnet_api.Data;
using dotnet_api.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_api.Services;

public class RecipeService
{
    private readonly RecipeContext context;

    public RecipeService(RecipeContext context)
    {
        this.context = context;
    }

    public IEnumerable<Recipe> GetAll(long userId)
    {
        return context.Recipes
            .Where(r => r.UserId == userId)
            .AsNoTracking()
            .ToList();
    }

    public IEnumerable<IngredientList> GetAllLists(long recipeId)
    {
        var ingredients = context.IngredientsLists
            .Where(i => i.RecipeId == recipeId)
            .AsNoTracking()
            .ToArray();

        foreach (var ing in ingredients)
        {
            ing.Preparation = "filled";
            context.SaveChanges();
        }

        return ingredients;
    }

    public void GetById(long recipeId)
    {
        var recipe = context.Recipes
            .Where(r => r.Id == recipeId)
            .AsNoTracking()
            .SingleOrDefault();

        var list = context.IngredientsLists
            .Where(list => list.RecipeId == recipeId)
            .AsNoTracking()
            .ToList();

        List<Ingredient> ingredients = new();
        foreach (var ing in list)
        {
            var ingredient = context.Ingredients
                .Where(i => i.Id == ing.Id)
                .AsNoTracking()
                .FirstOrDefault();

            if (ingredient is not null)
                ingredients.Add(ingredient);
        }

        var methods = context.Methods
            .Where(m => m.RecipeId == recipeId)
            .AsNoTracking()
            .ToList();

    }

    public async Task<Recipe>? UpdateRecipe(long userId, long recipeId)
    {
        var recipe = await context.Recipes
            .Where(r => r.UserId == userId && r.Id == recipeId)
            .AsNoTracking()
            .SingleOrDefaultAsync();

        if (recipe is null)
        {
            return new Recipe();
        }

        var ingList = await context.IngredientsLists
            .Where(r => r.RecipeId == recipeId)
            .AsNoTracking()
            .ToListAsync();

        foreach (var ing in ingList)
        {
            ing.Preparation = "diced";
        }

        context.IngredientsLists
            .UpdateRange(ingList);
        await context.SaveChangesAsync();

        return recipe;
    }
}