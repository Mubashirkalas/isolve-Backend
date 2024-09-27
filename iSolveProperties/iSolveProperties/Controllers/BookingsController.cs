using iSolveProperties.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace iSolveProperties.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public async Task<IActionResult> GetBookings([FromQuery] string userId, [FromQuery] string projectStatus)
        {
            if (string.IsNullOrWhiteSpace(userId))
            {
                return BadRequest("User ID is required.");
            }

            // Get BP_Code (DealerCode) using userId
            var dealerCode = await _bookingService.GetBpCodeByUserIdAsync(userId);
           

            if (string.IsNullOrEmpty(dealerCode))
            {
                return NotFound("Dealer code not found for the provided user ID.");
            }

            // Fetch bookings using DealerCode
            var bookings = await _bookingService.GetBookingsAsync(dealerCode,projectStatus);

            if (bookings == null || !bookings.Any())
            {
                return NotFound("No bookings found for the given dealer code and project status.");
            }
            return Ok(bookings);
        }
    }
}
