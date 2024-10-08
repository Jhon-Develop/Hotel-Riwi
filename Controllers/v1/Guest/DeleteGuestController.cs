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
    public class DeleteGuestController : ControllerBase
    {

        private readonly IHotelService _hotelService;

        public DeleteGuestController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Execute(int id)
        {
            await _hotelService.DeleteGuestAsync(id);
            return NoContent();
        }
    }
}