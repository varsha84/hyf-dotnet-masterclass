using Microsoft.AspNetCore.Mvc;
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

    [HttpGet("MealList")]
    public List<Meal> MealList()
    {

        return _repo.MealList().ToList();
    }

    [HttpPost("AddMeal")]
    public void AddMeal([FromBody] Meal m)
    {
        _repo.AddMeal(m);
    }
    [HttpGet("GetMealByID")]
    Meal GetMealByID(int ID)
    {

        return _repo.GetMealByID(ID);
    }



}