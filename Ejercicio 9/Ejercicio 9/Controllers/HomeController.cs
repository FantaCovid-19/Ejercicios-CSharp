using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio_9.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /*
            Creamos la clase del controlador para la vista
            Recomiendo poner el mismo nombre que la vista
         */
        public ActionResult MyView()
        {
            ViewBag.Message = "Esto es una vista";

            return View();
        }
    }
}