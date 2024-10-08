using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hotel_Riwi.Models;
using Hotel_Riwi.Services;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using ModelBooking = Hotel_Riwi.Models.Booking;

namespace Hotel_Riwi.Controllers.v1.Booking
{
    [ApiController]
    [Route("api/v1/bookings")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Booking")]
    public class GetBookingsController : ControllerBase
    {
        private readonly BookingService _bookingService;

        public GetBookingsController(BookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [SwaggerOperation(Summary = "Retrieve all bookings", Description = "Get a list of all bookings in the system.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Bookings retrieved successfully.")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error.")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModelBooking>>> GetAllBookings()
        {
            try
            {
                var bookings = await _bookingService.GetAllBookingsAsync();
                return Ok(bookings);
            }
            catch (ArgumentException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error.");
            }
        }
    }
}