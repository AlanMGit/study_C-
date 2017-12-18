using Curso_1931___Dev_App_Web_com_ASP.NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curso_1931___Dev_App_Web_com_ASP.NET_MVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {

            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Date = DateTime.Now },
                new Product { Id = 2, Name = "Product 2", Date = DateTime.Now }
            };

            return View(products);
        }

        public ActionResult Details(int id)
        {

            var product = new Product()
            {
                Id = id,
                Name = "Product 01"
            };

            return View(product);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateProductViewModel model)
        {
            var product = new Product()
            {
                Id = 1,
                Date = DateTime.Now,
                Name = model.Title
            };

            return View("Index");
        }
    }
}