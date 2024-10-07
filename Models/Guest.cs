using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Riwi.Models
{
    [Table("guests")]
    public class Guest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("first_name")]
        public string FirstName { get; set; }

        [Required]
        [Column("last_name")] 
        public string LastName { get; set;}

        [Required]
        [Column("email")]
        public string Email { get; set; }

        [Required]
        [Column("identification_number")]
        public string IdentificationNumber { get; set; }

        [Required]
        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        [Column("birthdate")]
        public DateOnly Birthdate { get; set; }
    }
}