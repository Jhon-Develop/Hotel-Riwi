using Hotel_Riwi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Riwi.Services.Controllers.v1.Room
{
    [ApiController]
    [Route("api/v1/rooms")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Room")]

    public class RoomController : ControllerBase
    {

        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet("rooms/available")]
        public async Task<IActionResult> GetAvailableRooms()
        {
            var availableRooms = await _roomService.GetAvailableRoomsAsync();
            return Ok(availableRooms);
        }

        [HttpGet("rooms/status")]
        public async Task<IActionResult> GetRoomsStatus()
        {
            var status = await _roomService.GetRoomsStatusAsync();
            return Ok(status);
        }

        [HttpGet("room_types")]
        public async Task<IActionResult> GetAllRoomTypes()
        {
            var roomTypes = await _roomService.GetAllRoomTypesAsync();
            return Ok(roomTypes);
        }

        [HttpGet("room_types/{id}")]
        public async Task<IActionResult> GetRoomTypeById(int id)
        {
            var roomType = await _roomService.GetRoomTypeByIdAsync(id);
            if (roomType == null)
            {
                return NotFound();
            }
            return Ok(roomType);
        }
    }
}
