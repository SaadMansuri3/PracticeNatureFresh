using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NatureFreshEF.Models;
using Data.Entities;
using Data;
using System.Net;
using RegCustomer = Data.Entities.RegCustomer;
using Data.Repository;

namespace NatureFreshEF.Controllers
{
    public class ProfileController : Controller
    {
        CustomerDb db = new CustomerDb();
        RegisterRepo repo;
        // GET: Manage

        public ProfileController()
        {
            repo = new RegisterRepo(new CustomerDb());
        }


        public ActionResult Index()
        {

            LoginViewModel objLoginModel = new LoginViewModel();
            RegisterViewModel objRegModel = new RegisterViewModel();
            var check = db.RegCustomers.Where(x => x.id);
            Session["IdSS"] = objRegModel.Id;
            var SID = Convert.ToInt32(Session["IdSS"]);

            if (checkLogin != null)
            {
                var cust = repo.GetCustomerById(SID);
                if (cust == null)
                    return View(Mapper.MapCust(cust));
                return RedirectToAction("Index");
            }

            return View(objRegModel);
            //var cust = repo.GetCustomerById(id);*/
            /*var cust = repo.GetCustomers();
            var data = new List<NatureFreshEF.Models.RegisterViewModel>();
            foreach (var c in cust)
           {
                data.Add(Mapper.MapCust(c));
            }
            return View(data);*/

        }

        public ActionResult GetCustomerById(int id)
        {

            var cust = repo.GetCustomerById(id);
            if (cust == null)
                return View(Mapper.MapCust(cust));
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ViewResult Create()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Create(RegisterViewModel cust)
        {
            if (ModelState.IsValid)
            {
                repo.AddCustomer(Mapper.DbMapView(cust));
                return RedirectToAction("Index");
            }
            return View(cust);
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (id < 1)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var cust = repo.GetCustomerById(id);
            if (cust == null)
            {
                return HttpNotFound();
            }

            return View(Mapper.MapCust(cust));
        }


        [HttpPost]
        public ActionResult Edit(RegisterViewModel RegCustView, int id)
        {
            if (ModelState.IsValid)
            {
                repo.UpdateCustomer(Mapper.DbMapView(RegCustView));
                return RedirectToAction("Index");
            }
            return View(RegCustView);
        }

    }
}

