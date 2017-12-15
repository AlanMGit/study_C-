using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curso_1931___Dev_App_Web_com_ASP.NET_MVC.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.userName = "Alan Martins";

            // Somente é válida enquanto a view estiver sendo renderizada
            TempData["UserName"] = "Alan Martins";
            return View();
        }

        public ActionResult User()
        {
            Session["UserName"] = "Alan Martins";
            return View();
        }
    }
}