using Microsoft.AspNetCore.Mvc;
namespace MealsharingNET.Controllers;

[ApiController]
[Route("api/reservations")]
public class ReservationController : ControllerBase
{
    private IReservationRepository _repo;

    public ReservationController(IReservationRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("")]
    public async Task<IEnumerable<Reservation>> GetReservations()
    {

        return await _repo.ListReservations();
    }

    [HttpPost("")]
    public async Task AddReservation([FromBody] Reservation r)
    {
        await _repo.AddReservation(r);
    }

    [HttpGet("{id}")]
    public async Task <List<Reservation>> GetMealReservations(int id)
    {
        return await _repo.GetMealReservations(id);


    }
    
}