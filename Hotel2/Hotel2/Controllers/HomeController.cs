using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel2.Models;
using Hotel2.Controllers;

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
            ViewBag.ListaHotel = new List<Hotel2.Models.Hotel>() { new Models.Hotel() { Name="Hotel1", Rooms = new List<Models.Room>() { new Models.Room() { Id=1,Type=1 } } } };
            ViewBag.ListCliente = new List<string>() { "Cliente1", "Cliente2", "Cliente3" };
            return View();
        }
        public Hotel Search(int id)
        {

            using (HotelDbContext ct = new HotelDbContext())
            {
                return ct.Hotels.FirstOrDefault(x => x.Id == id);
            }
            
        }
    }
}