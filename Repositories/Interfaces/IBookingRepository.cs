using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_Riwi.Models;

namespace Hotel_Riwi.Repositories.Interfaces
{
    public interface IBookingRepository
    {
        Task<IEnumerable<Booking>> GetBookingsByGuestIdentificationNumberAsync(string identificationNumber);
        Task<Booking> GetBookingByIdAsync(int id);
        Task<Booking> GetBookingsByGuestIdAsync (int id);
        Task<IEnumerable<Booking>> GetAllBookingsAsync();
        Task AddBookingAsync(Booking booking);
        Task UpdateBookingAsync(Booking booking);
        Task DeleteBookingAsync(int id);
    }
}