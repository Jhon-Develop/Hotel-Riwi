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

    public class SearchGuestsController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public SearchGuestsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet("search/{keyword}")]
        public async Task<IActionResult> Execute(string keyword)
        {
            var guests = await _hotelService.SearchGuestsAsync(keyword);
            return Ok(guests);
        }
    }
}