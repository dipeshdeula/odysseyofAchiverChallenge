﻿using System.ComponentModel.DataAnnotations;

namespace studentProjectWeb.Models
{
    public class AddStudentViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]

        public string Phone { get; set; }

        public bool Subscribed { get; set; }    

      
    }
}
