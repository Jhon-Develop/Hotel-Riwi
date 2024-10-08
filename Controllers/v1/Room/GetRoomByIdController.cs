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
    public class GetRoomByIdController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public GetRoomByIdController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Execute(int id)
        {
            var room = await _hotelService.GetRoomByIdAsync(id);
            if (room == null)
            {
                return NotFound();
            }
            return Ok(room);
        }
    }
}