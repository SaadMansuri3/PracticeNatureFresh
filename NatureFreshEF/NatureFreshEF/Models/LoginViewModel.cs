using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NatureFreshEF.Models
{
    public class LoginViewModel
    {
        [ForeignKey("CustId")]
        public int? CustId { get; set; }
        [Required(ErrorMessage = "Username Cannot Be Blank")]
        public string Username { get; set; }
        //

        [Required(ErrorMessage = "Password Cannot Be Blank")]
        public string Password { get; set; }

    }
}