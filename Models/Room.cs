using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Riwi.Models
{
    [Table("rooms")]
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("room_number")]
        public string RoomNumber { get; set; }

        [Required]
        [Column("room_type_id")]
        public int RoomTypeId { get; set; }

        [Required]
        [Column("price_per_night")]
        public double PricePerNight { get; set; }

        [Required]
        [Column("availability")]
        public bool Availability { get; set; }
        
        [Required]
        [Column("max_occupancy_persons")]
        public byte MaxOccupancyPersons { get; set; }

        [ForeignKey("RoomTypeId")]        
        public RoomType RoomType { get; set; }
    }
}