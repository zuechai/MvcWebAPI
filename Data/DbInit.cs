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
        Recipe guacamole = new Recipe
        {
            Title = "Guacamole",
            ImagePath = null,
            User = user,
        };

        // Add ingredients
        Ingredient onion = new Ingredient { Name = "onion" };
        Ingredient avocado = new Ingredient { Name = "avocado" };
        Ingredient cilantro = new Ingredient { Name = "cilantro" };
        Ingredient jalapeno = new Ingredient { Name = "jalapeno" };
        Ingredient limeJuice = new Ingredient { Name = "lime juice" };

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
                Ingredient = onion,
                Preparation = "brunoise",
                Recipe = guacamole
            },
            new IngredientList
            {
                Measurement = "2 avocados",
                Ingredient = avocado,
                Recipe = guacamole
            },
            new IngredientList
            {
                Measurement = "2 tablespoons",
                Ingredient = cilantro,
                Preparation = "chiffonade",
                Recipe = guacamole
            },
            new IngredientList
            {
                Measurement = "2 teaspoons",
                Ingredient = jalapeno,
                Preparation = "brunoise",
                Recipe = guacamole
            },
            new IngredientList
            {
                Measurement = "1 tablespoon",
                Ingredient = limeJuice,
                Recipe = guacamole
            }
        };

        // add Methods
        Method[] methods = new Method[]
        {
            new Method
            {
                StepNumber = 1,
                Instruction = "Add everything but the lime to a bowl or large mortar and pestle then mash the avocado into a chunky paste so that the pieces are pea-sized.",
                Recipe = guacamole
            },
            new Method
            {
                StepNumber = 2,
                Instruction = "Gently stir in lime juice and 1/4 teaspoon kosher salt or to taste.",
                Recipe = guacamole
            },
            new Method
            {
                StepNumber = 3,
                Instruction = "Serve immediately or store in an airtight container with plastic wrap press onto the exposed surface.",
                Recipe = guacamole
            }
        };

        context.Users.Add(user);
        context.Recipes.Add(guacamole);
        context.IngrdientsLists.AddRange(ingredients);
        context.Methods.AddRange(methods);
        context.SaveChanges();
    }
}