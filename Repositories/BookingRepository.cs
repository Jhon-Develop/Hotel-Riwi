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

        public BookingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Booking>> GetAllBookingsAsync()
        {
            return await _context.Bookings
                .Include(b => b.Guest)
                .Include(b => b.Room)
                .ToListAsync();
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
    }
}
