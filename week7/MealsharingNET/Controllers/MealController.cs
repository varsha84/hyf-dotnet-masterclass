using Microsoft.AspNetCore.Mvc;
using MealsharingNET;
namespace MealsharingNET.Controllers;



[ApiController]
[Route("api/meals")]
public class MealController : ControllerBase
{
    private IMealRepository _repo;

    public MealController(IMealRepository repo)
    {
        _repo = repo;
    }
    /* All meals in list*/
    
    [HttpGet("")]
    public async Task<IEnumerable<Meal>> MealsList()
    {

        return await _repo.MealsList();
    }

    /* Add a meal in meal list*/

    [HttpPost("")]
    public void AddMeal([FromBody] Meal m)
    {
        _repo.AddMeal(m);
    }

    /* find a meal in list by id*/

    [HttpGet("{id}")]
    public async Task<Meal> GetMealByID(int id)
    {

        return await _repo.GetMealById(id);
    }

  
}