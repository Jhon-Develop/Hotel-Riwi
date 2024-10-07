using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class GetBookingByIdController : BaseBookingsController
    {
        public GetBookingByIdController(BookingService bookingService) : base(bookingService) { }

        [SwaggerOperation(Summary = "Retrieve booking by ID", Description = "Get a specific booking by its ID.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Booking retrieved successfully.")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Booking not found.")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error.")]
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<BookingModel>> GetBooking(int id)
        {
            try
            {
                var booking = await _bookingService.GetBookingByIdAsync(id);
                if (booking == null)
                {
                    return NotFound();
                }
                return Ok(booking);
            }
            catch (ArgumentException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error.");
            }
        }
    }
}