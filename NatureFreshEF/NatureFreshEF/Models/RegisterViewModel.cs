using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NatureFreshEF.Models
{
    public class RegisterViewModel
    {
        
            [HiddenInput]
            public int Id { get; set; }
            //
            [Required(ErrorMessage = "Name Cannot Be Blank")]
            [StringLength(maximumLength: 20, ErrorMessage = "Name Should be between 2 to 20 characters", MinimumLength = 2)]
            public string Name { get; set; }
            //

            [Required(ErrorMessage = "Username Cannot Be Blank")]
            [StringLength(maximumLength: 20, ErrorMessage = "Username Should be between 3 to 20 characters", MinimumLength = 3)]
            public string Username { get; set; }
            //

            [Required(ErrorMessage = "Password Cannot Be Blank")]
            [StringLength(maximumLength: 20, ErrorMessage = "Password Should be between 5 to 20 characters", MinimumLength = 5)]
            public string Password { get; set; }
            //

            [Required(ErrorMessage = "Age Cannot Be Blank")]
            [Range(5, 100, ErrorMessage = "Age Should be Between 5 and 100")]
            public int Age { get; set; }
            //

            [Required(ErrorMessage = "Address Cannot Be Blank")]
            [StringLength(maximumLength: 200, ErrorMessage = "Address Should be between 10 to 200 characters", MinimumLength = 10)]
            public string Address { get; set; }
            //

            [Required(ErrorMessage = "Zipcode Cannot Be Blank")]
            [RegularExpression(@"([0-9]+)", ErrorMessage = "Must be a Number.")]
            [StringLength(maximumLength: 6, ErrorMessage = "Zipcode Should be 6 Digits", MinimumLength = 6)]
            public string Zipcode { get; set; }
            //

            [Required(ErrorMessage = "Mobile Cannot Be Blank")]
            [RegularExpression(@"([0-9]+)", ErrorMessage = "Must be a Number.")]
            [StringLength(maximumLength: 10, ErrorMessage = "Mobile no. Should be 10 Digits", MinimumLength = 10)]
            public string Mobile { get; set; }

            [Required(ErrorMessage = "Email Cannot Be Blank")]
            public string Email { get; set; }
       
    }
}
