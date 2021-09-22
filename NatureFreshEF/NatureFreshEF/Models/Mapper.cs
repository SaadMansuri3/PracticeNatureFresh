using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.Entities;
using NatureFreshEF.Models;

namespace NatureFreshEF.Models
{
    public static class Mapper
    {
        public static RegCustomer DbMapView(RegisterViewModel RegCustView)
        {
            return new RegCustomer()
            {
                id = RegCustView.id,
                Name = RegCustView.Name,
                Username = RegCustView.Username,
                Password = RegCustView.Password,
                age = RegCustView.Age,
                Address = RegCustView.Address,
                Zipcode = RegCustView.Zipcode,
                Mobile = RegCustView.Mobile,
                Email = RegCustView.Email
            };
        }
        public static NatureFreshEF.Models.RegisterViewModel MapCust(Data.Entities.RegCustomer cust)
        {
            return new NatureFreshEF.Models.RegisterViewModel()
            {

                id = cust.id,
                Name = cust.Name,
                Username = cust.Username,
                Password = cust.Password,
                Age = cust.age,
                Address = cust.Address,
                Mobile = cust.Mobile,
                Email = cust.Email
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
        public static ProductsModel ProductDbMapView(Products ProdDb)
        {
            return new ProductsModel()
            {
                Id = ProdDb.Id,
                Name = Capitalize(ProdDb.Name),
                Quantity = ProdDb.Quantity,
                Price = ProdDb.Price
            };
        }
        public static string Capitalize(this string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
        }
    }
}