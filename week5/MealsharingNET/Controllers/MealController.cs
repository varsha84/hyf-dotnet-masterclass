using Microsoft.AspNetCore.Mvc;
using MealsharingNET;
namespace MealsharingNET.Controllers;



[ApiController]
[Route("Meals")]
public class MealController : ControllerBase
{
    private IMealRepository _repo;

    public MealController(IMealRepository repo)
    {
        _repo = repo;
    }
    /* All meals in list*/
    
    [HttpGet("MealList")]
    public async Task<IEnumerable<Meal>> MealsList()
    {

        return await _repo.MealsList();
    }

    /* Add a meal in meal list*/
    
    [HttpPost("AddMeal")]
    public async Task AddMeal([FromBody] Meal m)
    {
        await _repo.AddMeal(m);
    }
    /* find a meal in list by id*/

    [HttpGet("GetMealByID")]
    public async Task<Meal> GetMealByID(int id)
    {

        return await _repo.GetMealById(id);
    }

    /* Delete meal from list*/

    [HttpDelete("Delete")]
    public async Task DeleteMeal(int id)
    {
        await _repo.DeleteMeal(id);
    }

}