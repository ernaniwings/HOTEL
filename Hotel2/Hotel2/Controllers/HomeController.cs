﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel2.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Projeto realizado para as disciplinas de Computação em nuvem e Tecnicas de projeto de sistemas." + CurrentUser.Email;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Entre em contato conosco.";

            return View();
        }
        
        public ActionResult Home()
        {
            ViewBag.ListaProduto = new List<string>() { "Produto1", "Produto2", "Produto3" };
            ViewBag.ListaHotel = new List<string>() { "Hotel1", "Hotel2", "Hotel3" };
            ViewBag.ListCliente = new List<string>() { "Cliente1", "Cliente2", "Cliente3" };
            return View();
        }
    }
}