using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_Riwi.Models;

namespace Hotel_Riwi.Services.Interfaces
{
    public interface IRoomService
    {
        Task<IEnumerable<Room>> GetAvailableRoomsAsync();
        Task<object> GetRoomsStatusAsync();

        // Métodos para los tipos de habitaciones
        Task<IEnumerable<RoomType>> GetAllRoomTypesAsync();
        Task<RoomType> GetRoomTypeByIdAsync(int id);
    }
}