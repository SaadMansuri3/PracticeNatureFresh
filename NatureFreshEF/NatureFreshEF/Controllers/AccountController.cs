using System;
using System.Web;
using System.Web.Mvc;
using NatureFreshEF.Models;
using Data.Entities;
using Data.Repository;

namespace NatureFreshEF.Controllers
{
    public class AccountController : Controller
    {
        CustomerDb db = new CustomerDb();
        RegisterRepo repo;

        public AccountController() // Mandatory Constructor, if not given the program will throw Exc 'repo is null'
        {
            repo = new RegisterRepo(new CustomerDb());
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            RegisterViewModel objRegModel = new RegisterViewModel();
            return View(objRegModel);
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel objRegModel)
        {
            if (ModelState.IsValid)
            {
                RegCustomer objRegCust = new RegCustomer();
                //objRegCust.Name = objRegModel.Name;
                //objRegCust.Username = objRegModel.Username;
                //objRegCust.Password = objRegModel.Password;
                //objRegCust.Address = objRegModel.Address;
                //objRegCust.Zipcode = objRegModel.Zipcode;
                //objRegCust.age = objRegModel.Age;
                //objRegCust.Mobile = objRegModel.Mobile;
                //objRegCust.Email = objRegModel.Email;

                //repo.AddCust(objRegCust); //AddCust is a Method From Repo
                repo.AddCust(Mapper.DbMapView(objRegModel));
                repo.Save();
                //db.RegCustomers.Add(objRegCust);
                //db.SaveChanges();
                return View(objRegModel);
            }
            return View();
        }

        public ActionResult Login()
        {
            LoginViewModel objLoginModel = new LoginViewModel();
            return View(objLoginModel);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel objLoginModel)
        { 
            return View();
        }
    }
}