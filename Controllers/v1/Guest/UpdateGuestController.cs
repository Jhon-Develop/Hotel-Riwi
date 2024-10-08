using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_Riwi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ModelGuest = Hotel_Riwi.Models.Guest;

namespace Hotel_Riwi.Controllers.v1.Guest
{
    [ApiController]
    [Route("api/v1/guest")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Guest")]

    public class UpdateGuestController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public UpdateGuestController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Execute(int id, [FromBody] ModelGuest guest)
        {
            if (id != guest.Id)
            {
                return BadRequest();
            }

            await _hotelService.UpdateGuestAsync(guest);
            return NoContent();
        }
    }
}