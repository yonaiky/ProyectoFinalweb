using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Hazte_Socio()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult sobre_Price()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }

}