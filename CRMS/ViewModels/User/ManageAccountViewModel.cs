﻿
using System.ComponentModel.DataAnnotations;

namespace CRMS.ViewModels.User
{
    public class ManageAccountViewModel
    {
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }


        
        public string? Username { get; set; }


        [Required]
        //[RequiredIf("NewPassword","",ErrorMessage = "The Existing Password field is required.")]
        [Display(Name = "Old Password")]
        [DataType(DataType.Password)]
        public string? ExistingPassword { get; set; }

        [Required]
        //[RequiredIf("ConfirmNewPassword", "", ErrorMessage = "The Existing Password field is required.")]
        [Display(Name = "New Password")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage ="New Password must be at least 6 characters long")]
        
        public string? NewPassword { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Confirm Password must be at least 6 characters long")]
        [Compare(nameof(NewPassword), ErrorMessage = "New Password and Confirm New Password do not match.")]
        public string? ConfirmNewPassword { get; set; }
    }


}
