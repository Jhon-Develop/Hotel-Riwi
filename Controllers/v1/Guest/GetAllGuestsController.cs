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

    public class GetAllGuestsController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public GetAllGuestsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet]
        public async Task<IActionResult> Execute()
        {
            var guests = await _hotelService.GetAllGuestsAsync();
            return Ok(guests);
        }
    }
}