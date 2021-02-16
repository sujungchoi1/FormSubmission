using System;
using System.ComponentModel.DataAnnotations;
using FormSubmission.Controllers;
namespace FormSubmission.Models
{
    public class User
    {
        [Required(ErrorMessage="You must provide your first name")]
        [Display(Name = "First Name")]
        [MinLength(4, ErrorMessage="First Name must be at least 4 characters")]
        [NoZNames]
        public string FirstName { get;set; }

        [Required(ErrorMessage="You must provide your last name")]
        [MinLength(4, ErrorMessage="Last Name must be at least 4 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get;set; }

        [Required(ErrorMessage="You must provide your age")]
        [Range(0,200, ErrorMessage="Age must be a positive number")]
        public int Age { get;set; }

        [Required(ErrorMessage="You must provide your email address")]
        [EmailAddress(ErrorMessage="Email must be in valid email format")]
        [Display(Name = "Email Address")]
        public string Email { get;set; }

        [Required(ErrorMessage="You must provide a password")]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters long")]
        public string Password { get;set; }
        
        public DateTime Graduation { get;set; }

    }
}