using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_Riwi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Hotel_Riwi.Controllers.v1.Booking
{
    [ApiController]
    [Route("api/v1/bookings/delete")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Booking")]
    public class DeleteBookingController : BaseBookingsController
    {
        public DeleteBookingController(BookingService bookingService) : base(bookingService) { }

        [SwaggerOperation(Summary = "Delete a booking", Description = "Remove a booking from the system.")]
        [SwaggerResponse(StatusCodes.Status204NoContent, "Booking deleted successfully.")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Booking not found.")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error.")]
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            try
            {
                await _bookingService.DeleteBookingAsync(id);
                return NoContent();
            }
            catch (ArgumentException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error.");
            }
        }
    }
}