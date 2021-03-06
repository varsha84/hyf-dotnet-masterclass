
using System.Collections.Generic;
using System.Threading.Tasks;
using MealsharingNET;
using MySql.Data.MySqlClient;
using Dapper;

public class MealRepository: IMealRepository {

     public async Task AddMeal(Meal meal)
    {

        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var mealId = await connection.ExecuteAsync("INSERT INTO meals VALUES (@ID, @Title, @Description, @Price, @ImageUrl,@Location,@MaxReservations, @Created_date, @When)", meal);
    }

    public async Task DeleteMeal(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("DELETE FROM meals WHERE id=@ID", new { ID = id });
    }

    public async Task<Meal> GetMealById(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meal = await connection.QueryFirstAsync<Meal>("SELECT * FROM meals WHERE ID=@MealId", new { MealId = id });
        return meal;
    }
    public async Task<IEnumerable<Meal>> MealsList()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        Console.WriteLine("connection success");
        var meals = await connection.QueryAsync<Meal>("SELECT * FROM meals");
        return meals;
    }
    public async Task UpdateMeal(Meal meal)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("UPDATE meals SET id=@ID, title=@Title, description=@Description, price=@Price, imageUrl=@ImageUrl, location=@Location, maxReservation=@MaxReservation, created_date=@Created_date, when=@When WHERE id=@id", meal);
    }
}



   

   
 