using dotnet_api.Models;
using dotnet_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_api.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipeController : ControllerBase
{
    RecipeService service;

    public RecipeController(RecipeService service)
    {
        this.service = service;
    }

    [HttpGet("{userId}")]
    public IEnumerable<Recipe> GetAll(int userId)
    {
        var recipes = service.GetAll(userId);

        return recipes;
    }

    [HttpGet("recipeId")]
    public ActionResult GetAllList(long recipeId)
    {
        return Ok(service.GetAllLists(recipeId));    
    }

    [HttpGet("{userId}/{recipeId}")]
    public void GetById(int recipeId)
    {
        Ok();
    }

    [HttpPost("{userId}/{recipeId}")]
    public ActionResult<Recipe> UpdateRecipe(long userId, long recipeId)
    {
        var recipe = service.UpdateRecipe(userId, recipeId);

        if (recipe != null)
        {
            return Ok(recipe);
        }

        return BadRequest(recipe);
    }
}
