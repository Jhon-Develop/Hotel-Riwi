using BookingModel = Hotel_Riwi.Models.Booking;
using Hotel_Riwi.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Hotel_Riwi.Models.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace Hotel_Riwi.Controllers.v1.Booking
{
    [ApiController]
    [Route("api/v1/bookings")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Booking")]
    public class PostBookingController : BaseBookingsController
    {
        public PostBookingController(BookingService bookingService) : base(bookingService) { }

        [SwaggerOperation(Summary = "Create a new booking", Description = "Creates a new booking with the specified room, guest, employee, start date, end date, and automatically calculates the total cost.")]
        [SwaggerResponse(StatusCodes.Status201Created, "Booking created successfully.")]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid booking data.")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Room not found.")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "An error occurred while creating the booking.")]
        [HttpPost]
        public async Task<ActionResult<BookingModel>> PostBooking([FromBody] BookingDto bookingDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var booking = new BookingModel
                {
                    RoomId = bookingDto.RoomId,
                    GuestId = bookingDto.GuestId,
                    EmployeeId = bookingDto.EmployeeId,
                    StartDate = bookingDto.StartDate,
                    EndDate = bookingDto.EndDate,
                    TotalCost = bookingDto.TotalCost
                };

                await _bookingService.AddBookingAsync(booking);

                return StatusCode(StatusCodes.Status201Created, booking);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error.");
            }
        }
    }
}
