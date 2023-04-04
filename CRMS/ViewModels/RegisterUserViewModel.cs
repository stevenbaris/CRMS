﻿using System.ComponentModel.DataAnnotations;

namespace CRMS.ViewModels
{
    public class RegisterUserViewModel
    {
        // view validations
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [MinLength(5, ErrorMessage =
           "The Address is too short")]
        [Required]
        public string Address { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage ="Password and confirm password doesnt match")]
        public string  ConfirmPassword { get; set; }
    }
}
