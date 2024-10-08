using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_Riwi.Models;

namespace Hotel_Riwi.Services.Interfaces
{
    public interface IHotelService
    {
        Task<IEnumerable<Room>> GetAllRoomsAsync();
        Task<Room> GetRoomByIdAsync(int id);
        Task<IEnumerable<Room>> GetOccupiedRoomsAsync();
        Task<IEnumerable<Guest>> GetAllGuestsAsync();
        Task<Guest> GetGuestByIdAsync(int id);
        Task DeleteGuestAsync(int id);
        Task<IEnumerable<Guest>> SearchGuestsAsync(string keyword);
        Task UpdateGuestAsync(Guest guest);
    }
}