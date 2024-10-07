using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_Riwi.DataBase;
using Hotel_Riwi.Models;
using Hotel_Riwi.Repositories.Interfaces;

namespace Hotel_Riwi.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationDbContext _context;

        public RoomRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Room> GetRoomByIdAsync(int id)
        {
            return await _context.Rooms.FindAsync(id);
        }
    }
}