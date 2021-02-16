using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FormSubmission.Models;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("user/create")]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                return View("Success");
            }
            else
            {
                return View("Index");
            }
        }
    }

    // public abstract class ValidationAttribute : Attribute
    // {
    //     public virtual bool IsValid(object value);
    //     protected virtual ValidationResult IsValid(object value, ValidationContext validationContext);
    // }

    public class NoZNamesAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (((string)value).ToLower()[0] == 'z')
                return new ValidationResult("No names that start with Z allowed!");
            return ValidationResult.Success;
        }
    }

    // public class FutureDateAttribute : ValidationAttribute
    // {
    //     protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //     {
    //         // You first may want to unbox "value" here and cast to to a DateTime variable!
    //     }
    // }


}
