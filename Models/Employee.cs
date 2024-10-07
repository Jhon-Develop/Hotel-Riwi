using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Riwi.Models
{
    [Table("employees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("first_name")]
        public string FirstName { get; set; }

        [Required]
        [Column("last_name")]
        public string LastName { get; set; }

        [Required]
        [Column("email")]
        public string Email { get; set; }

        [Required]
        [Column("indentification_number")]
        public string IndentificationNumber { get; set; }

        [Required]
        [Column("password")]
        public string Password { get; set; }
    }
}