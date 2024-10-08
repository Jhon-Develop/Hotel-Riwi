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
    public class GetAllRoomsController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public GetAllRoomsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet]
        public async Task<IActionResult> Execute()
        {
            var rooms = await _hotelService.GetAllRoomsAsync();
            return Ok(rooms);
        }
    }
}