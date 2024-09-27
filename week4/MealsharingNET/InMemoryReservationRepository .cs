namespace MealsharingNET
{

    public class InMemoryReservationRepository : IReservationRepository
    {
        private static List<Reservation> Reservations { get; set; } = new List<Reservation>(){
        new Reservation(){ ID = 5, MealID = 1, Name = "Varsha", Email = "varsha@gmail.com", Date = "12/5/2017", NumOfPersons = 4},
        new Reservation(){ ID = 6, MealID = 2, Name = "Cris", Email = "cris@gmail.com", Date = "14/5/2019", NumOfPersons = 3},
        new Reservation(){ ID = 7, MealID = 3, Name = "Pia", Email = "pia@gmail.com", Date = "10/3/2020", NumOfPersons = 5}
    };
        public void CreateReservation(Reservation reservation)
        {
            Reservations.Add(reservation);
        }
        public IEnumerable<Reservation> ReservationList()
        {
            return Reservations;
        }
        public List<Reservation> GetReservations(int MealID)
        {
            var reservations = new List<Reservation>();
            foreach (var reservation in Reservations)
            {
                if (reservation.MealID == MealID)
                {
                    reservations.Add(reservation);
                }
            }
            return reservations;
        }
    }
}
