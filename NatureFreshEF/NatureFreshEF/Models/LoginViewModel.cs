using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


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
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //[Required(ErrorMessage = "Please Enter Your Password Once Again!")]
        //[Display(Name = " Confirm Password")]
        //[DataType(DataType.Password)]
        //[NotMapped]
        //[Compare("Password", ErrorMessage = "Confirm paassword does not match!")]

        //public string RePassword { get; set; }

    }
}