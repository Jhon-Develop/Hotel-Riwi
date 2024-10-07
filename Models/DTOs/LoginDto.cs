using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Riwi.Models.DTOs
{
    public class LoginDto
    {
        [Required]
        [MaxLength(100, ErrorMessage = "The name is very long")]
        [MinLength(3, ErrorMessage = "The name is too short")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "The password is very long")]
        [MinLength(6, ErrorMessage = "The password is too short")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}