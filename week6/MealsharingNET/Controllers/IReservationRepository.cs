
using MealsharingNET;
namespace MealsharingNET;
    public interface IReservationRepository
    {
        Task <IEnumerable<Reservation>> ListReservations();
        Task AddReservation(Reservation reservation);
        Task <List<Reservation>> GetMealReservations(int MealId);
        Task DeleteReservation(int id);
        Task UpdateReservation(Reservation Reservation);
    }
   
