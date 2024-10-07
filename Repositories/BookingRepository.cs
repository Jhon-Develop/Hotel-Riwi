using System.Collections.Generic;
using System.Threading.Tasks;
using Hotel_Riwi.DataBase;
using Hotel_Riwi.Models;
using Hotel_Riwi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Riwi.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IGuestRepository _guestRepository;
        private readonly IBookingRepository _bookingRepository;

        public BookingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Booking>> GetBookingsByGuestIdentificationNumberAsync(string identificationNumber)
        {
            // Suponiendo que tienes acceso al repositorio de huéspedes
            var guest = await _guestRepository.GetGuestByIdentificationNumberAsync(identificationNumber);
            if (guest == null)
            {
                return Enumerable.Empty<Booking>(); // O lanzar una excepción si prefieres
            }

            return (IEnumerable<Booking>)await _bookingRepository.GetBookingsByGuestIdAsync(guest.Id);
        }


        public async Task<Booking> GetBookingByIdAsync(int id)
        {
            return await _context.Bookings
                .Include(b => b.Guest)
                .Include(b => b.Room)
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task AddBookingAsync(Booking booking)
        {
            await _context.Bookings.AddAsync(booking);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBookingAsync(Booking booking)
        {
            _context.Bookings.Update(booking);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBookingAsync(int id)
        {
            var booking = await GetBookingByIdAsync(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Booking> GetBookingsByGuestIdAsync(int id)
        {
            return await _context.Bookings
                .Include(b => b.Guest)
                .Include(b => b.Room)
                .FirstOrDefaultAsync(b => b.GuestId == id);
        }

        public Task<IEnumerable<Booking>> GetAllBookingsAsync()
        {
            return _context.Bookings
                .Include(b => b.Guest)
                .Include(b => b.Room)
                .ToListAsync()
                .ContinueWith(task => task.Result.AsEnumerable());
        }

    }
}
