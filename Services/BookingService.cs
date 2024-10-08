using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hotel_Riwi.Models;
using Hotel_Riwi.Repositories.Interfaces;

namespace Hotel_Riwi.Services
{
    public class BookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IRoomRepository _roomRepository;

        public BookingService(IBookingRepository bookingRepository, IRoomRepository roomRepository)
        {
            _bookingRepository = bookingRepository;
            _roomRepository = roomRepository;
        }

        public async Task<IEnumerable<Booking>> GetAllBookingsAsync()
        {
            return await _bookingRepository.GetAllBookingsAsync();
        }

        public async Task<Booking> GetBookingByIdAsync(int id)
        {
            return await _bookingRepository.GetBookingByIdAsync(id);
        }

        public async Task AddBookingAsync(Booking booking)
        {
            var room = await _roomRepository.GetRoomByIdAsync(booking.RoomId);
            if (room == null)
            {
                throw new KeyNotFoundException("Room not found.");
            }

            var totalNights = (booking.EndDate.ToDateTime(TimeOnly.MinValue) - booking.StartDate.ToDateTime(TimeOnly.MinValue)).Days;

            if (totalNights <= 0)
            {
                throw new ArgumentException("The end date must be after the start date.");
            }

            booking.TotalCost = (decimal)(room.PricePerNight * totalNights);

            await _bookingRepository.AddBookingAsync(booking);
        }


        public async Task UpdateBookingAsync(Booking booking)
        {
            await _bookingRepository.UpdateBookingAsync(booking);
        }

        public async Task DeleteBookingAsync(int id)
        {
            await _bookingRepository.DeleteBookingAsync(id);
        }
    }
}
