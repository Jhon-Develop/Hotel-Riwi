using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_Riwi.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Riwi.Controllers.v1.Booking
{
    [ApiController]
    [Route("api/v1/bookings")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Booking")]
    public class BaseBookingsController : ControllerBase
    {

        protected readonly BookingService _bookingService;

        protected BaseBookingsController(BookingService bookingService)
        {
            _bookingService = bookingService;
        }
    }
}