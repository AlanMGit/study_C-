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
            return View();
        }

        public ActionResult Details(int id)
        {

            var product = new Product()
            {
                Id = id,
                name = "Product 01"
            };

            return View(product);
        }
    }
}