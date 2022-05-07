using MySql.Data.MySqlClient;
using Dapper;
using MealsharingNET;


public class ReservationRepository : IReservationRepository
{
    public async Task AddReservation(Reservation reservation)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("insert into reservations values (@ID, @Name, @MobileNo, @Email, @ReservationDate, @NumOfPersons, @MealID)", reservation);
    }

    public async Task DeleteReservation(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync(@"DELETE FROM reservations WHERE Id = @ID", new { Id = id });
    }

    public async Task<List<Reservation>> GetMealReservations(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meal = await connection.QueryAsync<Reservation>("select * from reservations where meal_id=@MealID", new { MealID = id} );
        return meal.ToList();
    }

    public async Task<IEnumerable<Reservation>> ListReservations()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meals = await connection.QueryAsync<Reservation>("select * from reservations");
        return meals;
    }
    public async Task UpdateReservation(Reservation reservation)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("UPDATE reservations SET id=@id, name=@Name, mobile_no=@MobileNo, email=@Email, reservation_date=@ReservationDate, num_of_person=@NumOfPersons, meal_id=@MealID WHERE id=@id", reservation);
    }

}

