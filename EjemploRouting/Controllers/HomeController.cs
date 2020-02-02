using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemploRouting.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        [Route]
        public ActionResult Index()
        {      
            return View();
        }
        [Route]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Route]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Route("Animal/{id?}/{raza:regex(^B.*)?}")]
        public ActionResult Animal(String id, String raza)
        {
            ViewBag.Tipo = id;
            ViewBag.Raza = raza;
            return View();
        }
    }
}