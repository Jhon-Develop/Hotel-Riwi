using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Riwi.Models.DTOs
{
    public class RegisterDto
    {
        [Required]
        [MaxLength(100, ErrorMessage = "The name is very long")]
        [MinLength(3, ErrorMessage = "The name is too short")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "The name is very long")]
        [MinLength(3, ErrorMessage = "The name is too short")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(120, ErrorMessage = "The email is very long")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "The number idenfication is very long")]
        [MinLength(3, ErrorMessage = "The number idenfication is too short")]
        [Display(Name = "Indentification Number")]
        public string IndentificationNumber { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "The Phone Number is very long")]
        [MinLength(3, ErrorMessage = "The Phone Number is too short")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Birthdate")]
        public DateOnly Birthdate { get; set; }
    }
}