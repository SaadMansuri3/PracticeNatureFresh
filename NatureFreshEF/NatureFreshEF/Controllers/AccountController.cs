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
            if(db.RegCustomers.Any(x => x.Username == objRegModel.Username))
            {
                ViewBag.Notification = "This Account is already existed";
                return View();
            }
            else if (ModelState.IsValid)
            {
                RegCustomer objRegCust = new RegCustomer();
                int id = repo.AddCust(Mapper.DbMapView(objRegModel));
                //Testing id Fetch
                repo.Save();
                //repo - db - regcustomers- local -[0].id

                Session["IdSS"] = objRegModel.id.ToString();
                Session["UsernameSS"] = objRegModel.Username.ToString();
                return RedirectToAction("Index", "Home");
                
            }
            return View();

        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public ActionResult Login()
        {
            LoginViewModel objLoginModel = new LoginViewModel();
            return View(objLoginModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel objLoginModel)
        {
            var checkLogin = db.LoginCustomers.Where(x => x.Username.Equals(objLoginModel.Username) && x.Password.Equals(objLoginModel.Password)).FirstOrDefault();
            if (ModelState.IsValid)
            {
                Session["IdUsSS"] = objLoginModel.CustId.ToString();
                Session["UsernameSS"] = objLoginModel.Username.ToString();
                LoginCustomer objLoginCust = new LoginCustomer();
                Lrepo.AddCust(Mapper.Map(objLoginModel));
                Lrepo.Save();
                return View(objLoginModel);
            }
            else if(checkLogin==null)
            {
                ViewBag.Notification = "Wrong Username or Password";
            }
            return View();
        }
    }
}