using dotnet_api.Models;

namespace dotnet_api.Data;

public static class DbInit
{
    public static void Init(RecipeContext context)
    {
        if (context.Users.Any()
            && context.Recipes.Any())
        {
            Console.WriteLine("Hit");
            return;
        }

        // Add User
        User user = new User
        {
            FirstName = "Anthony",
            LastName = "Zuech",
            Username = "zuechai",
            Email = "zuechai@gmail.com",
            CreatedAt = DateTime.Now

        };

        // Add Recipe
        Recipe guacamole = new()
        {
            Title = "Guacamole",
            ImagePath = null,
            UserId = user.Id,
        };

        // Add ingredients
        Ingredient onion = new() { Name = "onion" };
        Ingredient avocado = new() { Name = "avocado" };
        Ingredient cilantro = new() { Name = "cilantro" };
        Ingredient jalapeno = new() { Name = "jalapeno" };
        Ingredient limeJuice = new() { Name = "lime juice" };

        context.Add(onion);
        context.Add(avocado);
        context.Add(cilantro);
        context.Add(jalapeno);
        context.Add(limeJuice);

        // create an array of ingredients (ingredient list!)
        IngredientList[] ingredients = new IngredientList[]
        {
            new IngredientList
            {
                Measurement = "2 tablespoons",
                IngredientId = onion.Id,
                RecipeId = guacamole.Id
            },
            new IngredientList
            {
                Measurement = "2 avocados",
                IngredientId = avocado.Id,
                RecipeId = guacamole.Id
            },
            new IngredientList
            {
                Measurement = "2 tablespoons",
                IngredientId = cilantro.Id,
                RecipeId = guacamole.Id
            },
            new IngredientList
            {
                Measurement = "2 teaspoons",
                IngredientId = jalapeno.Id,
                RecipeId = guacamole.Id
            },
            new IngredientList
            {
                Measurement = "1 tablespoon",
                IngredientId = limeJuice.Id,
                RecipeId = guacamole.Id
            }
        };

        ingredients[0].Preparation = "brunoiseeee";
        ingredients[3].Preparation = "brunoise";
        ingredients[2].Preparation = "chiffonade";



        // add Methods
        Method[] methods = new Method[]
        {
            new Method
            {
                StepNumber = 1,
                Instruction = "Add everything but the lime to a bowl or large mortar and pestle then mash the avocado into a chunky paste so that the pieces are pea-sized.",
                RecipeId = guacamole.Id
            },
            new Method
            {
                StepNumber = 2,
                Instruction = "Gently stir in lime juice and 1/4 teaspoon kosher salt or to taste.",
                RecipeId = guacamole.Id
            },
            new Method
            {
                StepNumber = 3,
                Instruction = "Serve immediately or store in an airtight container with plastic wrap press onto the exposed surface.",
                RecipeId = guacamole.Id
            }
        };

        context.Users.Add(user);
        context.Recipes.Add(guacamole);
        context.IngredientsLists.AddRange(ingredients);
        context.Methods.AddRange(methods);
        context.SaveChanges();
    }
}