using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_Riwi.Models;

namespace Hotel_Riwi.Repositories.Interfaces
{
    public interface IRoomRepository
    {
        Task<Room> GetRoomByIdAsync(int roomId);
    }
}