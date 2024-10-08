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
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationDbContext _context;

        public RoomRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Métodos para las habitaciones
        public async Task<IEnumerable<Room>> GetAvailableRoomsAsync()
        {
            return await _context.Rooms
                                .Where(r => r.Availability)
                                .ToListAsync();
        }

        public async Task<IEnumerable<Room>> GetRoomsStatusAsync()
        {
            return await _context.Rooms.ToListAsync();
        }

        // Métodos para los tipos de habitaciones
        public async Task<IEnumerable<RoomType>> GetAllRoomTypesAsync()
        {
            return await _context.RoomTypes.ToListAsync();
        }

        public async Task<RoomType> GetRoomTypeByIdAsync(int id)
        {
            return await _context.RoomTypes.FindAsync(id);
        }

        public async Task<Room> GetRoomByIdAsync(int id)
        {
            return await _context.Rooms.FindAsync(id);
        }
    }
}