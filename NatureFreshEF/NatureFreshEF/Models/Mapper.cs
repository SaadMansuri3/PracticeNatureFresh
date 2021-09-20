using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.Entities;
using NatureFreshEF.Models;

namespace NatureFreshEF.Models
{
    public class Mapper
    {
        public static RegCustomer DbMapView(RegisterViewModel RegCustView)
        {
            return new RegCustomer()
            {
                id = RegCustView.Id,
                Name = RegCustView.Name,
                Username = RegCustView.Username,
                Password = RegCustView.Password,
                age = RegCustView.Age,
                Address = RegCustView.Address,
                Mobile = RegCustView.Mobile,
                Email = RegCustView.Email
            };
        }

        public static LoginCustomer Map(LoginViewModel loginView)
        {

            return new LoginCustomer()
            {
                CustId = loginView.CustId,
                Username = loginView.Username,
                Password = loginView.Password
            };
        }
    }
}