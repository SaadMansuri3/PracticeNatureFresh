using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.Repository;
using System.Web.Mvc;
using NatureFreshEF.Models;
using Data.Entities;

namespace NatureFreshEF.Controllers
{
    public class ProductsController : Controller
    {
        ProductsRepo repo;

        public ProductsController() // Mandatory Constructor, if not given the program will throw Exc 'repo is null'
        {
            repo = new ProductsRepo(new ProductsDb());
        }

        // GET: Products
        public ActionResult Index()
        {
            var products = repo.GetAllProducts();
            var data = new List<NatureFreshEF.Models.ProductsModel>();
            
            foreach(var x in products)
            {
                data.Add(Mapper.ProductDbMapView(x));
            }
            return View(data);
        }
    }
}