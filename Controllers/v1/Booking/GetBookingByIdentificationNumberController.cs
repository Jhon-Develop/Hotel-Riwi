using BookingModel = Hotel_Riwi.Models.Booking;
using Hotel_Riwi.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Authorization;

namespace Hotel_Riwi.Controllers.v1.Booking
{
    [ApiController]
    [Route("api/v1/bookings")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Booking")]
    public class GetBookingsByIdentificationNumberController : BaseBookingsController
    {
        public GetBookingsByIdentificationNumberController(BookingService bookingService) : base(bookingService)
        {
        }

        [SwaggerOperation(Summary = "Retrieve all bookings", Description = "Get a list of all bookings in the system.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Bookings retrieved successfully.")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error.")]
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingModel>>> GetBookings()
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

        [SwaggerOperation(Summary = "Search bookings by guest identification number", Description = "Retrieve bookings associated with a specific guest identification number.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Bookings retrieved successfully.")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "No bookings found for the given identification number.")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error.")]
        [Authorize]
        [HttpGet("search/{identification_number}")]
        public async Task<ActionResult<IEnumerable<BookingModel>>> GetBookingsByIdentificationNumber(string identification_number)
        {
            try
            {
                var bookings = await _bookingService.GetBookingsByGuestIdentificationNumberAsync(identification_number);
                
                if (bookings == null || !bookings.Any())
                {
                    return NotFound($"No bookings found for identification number {identification_number}.");
                }

                return Ok(bookings);
            }
            catch (ArgumentException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error.");
            }
        }
    }
}
