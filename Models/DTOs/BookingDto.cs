using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Riwi.Models.DTOs
{
    public class BookingDto
    {

        [Required]
        [Range(1, 50, ErrorMessage = "only room numbers between 1 and 50 are allowed")]
        [Display(Name = "Room Id")]
        public int RoomId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "the id of the guest must be greater than 0")]
        [Display(Name = "Guest Id")]
        public int GuestId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "the id of the guest must be greater than 0")]
        [Display(Name = "Employee Id")]
        public int EmployeeId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date booking")]
        public DateOnly StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date end booking")]
        public DateOnly EndDate { get; set; }

        
        public decimal TotalCost { get; set; }
    }
}