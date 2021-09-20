using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NatureFreshEF.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username Cannot Be Blank")]
        public string Username { get; set; }
        //

        [Required(ErrorMessage = "Password Cannot Be Blank")]
        public string Password { get; set; }

    }
}