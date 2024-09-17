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
        var reservations = await connection.QueryAsync<Reservation>("select * from reservations where meal_id=@MealID", new { MealID = id} );
        return reservations.ToList();
    }

    public async Task<IEnumerable<Reservation>> ListReservations()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reservations = await connection.QueryAsync<Reservation>("select * from reservations");
        return reservations;
    }


}