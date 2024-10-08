using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_Riwi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Riwi.Controllers.v1.Room
{
    [ApiController]
    [Route("api/v1/rooms")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Room")]
    public class GetOccupiedRoomsController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public GetOccupiedRoomsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet("occupied")]
        public async Task<IActionResult> Execute()
        {
            var occupiedRooms = await _hotelService.GetOccupiedRoomsAsync();
            return Ok(occupiedRooms);
        }
    }
}