using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_Riwi.Models;
using Hotel_Riwi.Repositories.Interfaces;

namespace Hotel_Riwi.Services
{
    public class HotelService : IHostService
    {
         private readonly IHotelRepository _hotelRepository;

    public HotelService(IHotelRepository hotelRepository)
    {
        _hotelRepository = hotelRepository;
    }

    // Métodos para las habitaciones
    public async Task<IEnumerable<Room>> GetAllRoomsAsync()
    {
        return await _hotelRepository.GetAllRoomsAsync();
    }

    public async Task<Room> GetRoomByIdAsync(int id)
    {
        return await _hotelRepository.GetRoomByIdAsync(id);
    }

    public async Task<IEnumerable<Room>> GetOccupiedRoomsAsync()
    {
        return await _hotelRepository.GetOccupiedRoomsAsync();
    }

    // Métodos para los huéspedes
    public async Task<IEnumerable<Guest>> GetAllGuestsAsync()
    {
        return await _hotelRepository.GetAllGuestsAsync();
    }

    public async Task<Guest> GetGuestByIdAsync(int id)
    {
        return await _hotelRepository.GetGuestByIdAsync(id);
    }

    public async Task DeleteGuestAsync(int id)
    {
        await _hotelRepository.DeleteGuestAsync(id);
    }

    public async Task<IEnumerable<Guest>> SearchGuestsAsync(string keyword)
    {
        return await _hotelRepository.SearchGuestsAsync(keyword);
    }

    public async Task UpdateGuestAsync(Guest guest)
    {
        await _hotelRepository.UpdateGuestAsync(guest);
    }
    }

    public interface IHostService
    {
    }
}