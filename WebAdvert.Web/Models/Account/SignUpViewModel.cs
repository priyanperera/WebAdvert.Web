﻿using System.ComponentModel.DataAnnotations;

namespace WebAdvert.Web.Models.Account
{
    public class SignUpViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and confirmation do not match.")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
