using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Riwi.Models
{
    [Table("bookings")]
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("room_id")]
        public int RoomId { get; set; }

        [Required]
        [Column("guest_id")]
        public int GuestId { get; set; }

        [Required]
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Required]
        [Column("start_date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Column("end_date")]
        public DateTime EndDate { get; set; }

        [Required]
        [Column("total_cost")]
        public decimal TotalCost { get; set; }

        [ForeignKey("RoomId")]
        public Room Room { get; set; }

        [ForeignKey("GuestId")]
        public Guest Guest { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}