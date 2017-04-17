using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Projeto realizado para as disciplinas de Computação em nuvem e Tecnicas de projeto de sistemas.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Entre em contato conosco.";

            return View();
        }
    }
}