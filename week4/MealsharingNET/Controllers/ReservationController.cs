using Microsoft.AspNetCore.Mvc;
namespace MealsharingNET.Controllers;

[ApiController]
[Route("Meals")]
public class ReservationController : ControllerBase
{
    private IReservationRepository _repo;

    public ReservationController(IReservationRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("ReservationList")]
    public List<Reservation> ReservationList()
    {

        return _repo.ReservationList().ToList();
    }

    [HttpPost("AddReservation")]
    public void AddReservation([FromBody] Reservation r)
    {
        _repo.CreateReservation(r);
    }

    [HttpGet("reservationByMealID")]
    List<Reservation> GetReservationsByMealID(int ID)
    {
        return _repo.GetReservations(ID);


    }

}