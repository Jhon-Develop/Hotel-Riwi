using System.Collections.Generic;
using System.Threading.Tasks;
using Hotel_Riwi.Models;
using Hotel_Riwi.Repositories.Interfaces;
using Hotel_Riwi.Services.Interfaces;

public class RoomService : IRoomService
{
    private readonly IRoomRepository _roomRepository;

    public RoomService(IRoomRepository roomRepository)
    {
        _roomRepository = roomRepository;
    }

    public async Task<IEnumerable<Room>> GetAvailableRoomsAsync()
    {
        return await _roomRepository.GetAvailableRoomsAsync();
    }

    public async Task<object> GetRoomsStatusAsync()
    {
        var rooms = await _roomRepository.GetRoomsStatusAsync();
        return new
        {
            TotalRooms = rooms.Count(),
            AvailableRooms = rooms.Count(r => r.Availability),
            OccupiedRooms = rooms.Count(r => !r.Availability)
        };
    }

    // Métodos para los tipos de habitaciones
    public async Task<IEnumerable<RoomType>> GetAllRoomTypesAsync()
    {
        return await _roomRepository.GetAllRoomTypesAsync();
    }

    public async Task<RoomType> GetRoomTypeByIdAsync(int id)
    {
        return await _roomRepository.GetRoomTypeByIdAsync(id);
    }
}