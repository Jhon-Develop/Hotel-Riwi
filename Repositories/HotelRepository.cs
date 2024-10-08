using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_Riwi.DataBase;
using Hotel_Riwi.Models;
using Hotel_Riwi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Riwi.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly ApplicationDbContext _context;

        public HotelRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Métodos para las habitaciones
        public async Task<IEnumerable<Room>> GetAllRoomsAsync()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<Room> GetRoomByIdAsync(int id)
        {
            return await _context.Rooms.FindAsync(id);
        }

        public async Task<IEnumerable<Room>> GetOccupiedRoomsAsync()
        {
            return await _context.Rooms.Where(r => !r.Availability).ToListAsync();
        }

        // Métodos para los huéspedes
        public async Task<IEnumerable<Guest>> GetAllGuestsAsync()
        {
            return await _context.Guests.ToListAsync();
        }

        public async Task<Guest> GetGuestByIdAsync(int id)
        {
            return await _context.Guests.FindAsync(id);
        }

        public async Task DeleteGuestAsync(int id)
        {
            var guest = await _context.Guests.FindAsync(id);
            if (guest != null)
            {
                _context.Guests.Remove(guest);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Guest>> SearchGuestsAsync(string keyword)
        {
            return await _context.Guests
                                .Where(g => g.FirstName.Contains(keyword) || g.Email.Contains(keyword))
                                .ToListAsync();
        }

        public async Task UpdateGuestAsync(Guest guest)
        {
            _context.Guests.Update(guest);
            await _context.SaveChangesAsync();
        }
    }
}