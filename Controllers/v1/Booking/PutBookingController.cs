using BookingModel = Hotel_Riwi.Models.Booking;
using Hotel_Riwi.Models.DTOs;
using Hotel_Riwi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Authorization;

namespace Hotel_Riwi.Controllers.v1.Booking
{
    [ApiController]
    [Route("api/v1/bookings/update")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Booking")]
    public class PutBookingController : BaseBookingsController
    {
        public PutBookingController(BookingService bookingService) : base(bookingService) { }

        [SwaggerOperation(Summary = "Update a booking", Description = "Update an existing booking in the system.")]
        [SwaggerResponse(StatusCodes.Status204NoContent, "Booking updated successfully.")]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid booking data.")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Booking not found.")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error.")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, [FromBody] BookingDto bookingDto)
        {
            if (id != bookingDto.RoomId)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var booking = new BookingModel
                {
                    Id = id,
                    RoomId = bookingDto.RoomId,
                    GuestId = bookingDto.GuestId,
                    EmployeeId = bookingDto.EmployeeId,
                    StartDate = bookingDto.StartDate,
                    EndDate = bookingDto.EndDate,
                    TotalCost = bookingDto.TotalCost
                };

                await _bookingService.UpdateBookingAsync(booking);
                return NoContent();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }
            catch (ArgumentException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error.");
            }
        }
    }
}