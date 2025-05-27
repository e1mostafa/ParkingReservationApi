using Microsoft.AspNetCore.Mvc;
using ParkingReservationApi.Models;
using ParkingReservationApi.Services;

namespace ParkingReservationApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParkingController : ControllerBase
    {
        private readonly ParkingReservationService _reservationService;

        public ParkingController(ParkingReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost]
        public IActionResult Reserve(ParkingReservation reservation)
        {
            var success = _reservationService.ReserveSpot(reservation);
            if (!success)
                return BadRequest(new { Message = "Spot is already reserved for the selected date." });

            return Ok(reservation);
        }

        [HttpGet("available")]
        public IActionResult GetAvailableSpots([FromQuery] DateTime date)
        {
            var availableSpots = _reservationService.GetAvailableSpots(date);
            return Ok(availableSpots);
        }

        // ✅ الميثود الجديدة لإلغاء الحجز
        [HttpDelete("{id}")]
        public IActionResult CancelReservation(int id)
        {
            var success = _reservationService.CancelReservation(id);
            if (!success)
                return NotFound(new { Message = "Reservation not found or already cancelled." });

            return Ok(new { Message = "Reservation cancelled successfully." });
        }
    }
}
