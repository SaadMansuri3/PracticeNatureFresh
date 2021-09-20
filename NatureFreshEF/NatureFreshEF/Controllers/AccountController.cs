using System;
using System.Linq;
using System.Web;
using System.ComponentModel;
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
        LoginRepo Lrepo;

        public AccountController() // Mandatory Constructor, if not given the program will throw Exc 'repo is null'
        {
            repo = new RegisterRepo(new CustomerDb());
            Lrepo = new LoginRepo(new CustomerDb());
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
                repo.AddCust(Mapper.DbMapView(objRegModel));
                repo.Save();
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
           
            if (ModelState.IsValid)
            {
                LoginCustomer objLoginCust = new LoginCustomer();
                Lrepo.AddCust(Mapper.Map(objLoginModel));
                Lrepo.Save();
                return View(objLoginModel);
            }
            return View();
        }
    }
}