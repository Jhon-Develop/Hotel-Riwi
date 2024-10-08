using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_Riwi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Riwi.Controllers.v1.Guest
{
    [ApiController]
    [Route("api/v1/guest")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Guest")]

    public class GetGuestByIdController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public GetGuestByIdController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Execute(int id)
        {
            var guest = await _hotelService.GetGuestByIdAsync(id);
            if (guest == null)
            {
                return NotFound();
            }
            return Ok(guest);
        }
    }
}