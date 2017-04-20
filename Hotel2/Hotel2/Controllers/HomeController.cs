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

        private HotelDbContext db = new HotelDbContext();

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
        [Authorize]
        public ActionResult Home()
        {

            ViewBag.ListaHotel = db.Hotels.ToList().Where(x => x.ApplicationUserId.Equals(CurrentUser.Id));
            return View();
        }

        public string CreateHotel(string id)
        {
            string nome = id;
            try
            {
                if (ModelState.IsValid)
                {
                    Hotel hotel = new Hotel()
                    {
                        Name = nome,
                        Description = "Your Description Here",
                        ApplicationUserId = CurrentUser.Id
                    };
                    db.Hotels.Add(hotel);
                    db.SaveChanges();
                }
                return "Sucess";
            }
            catch (Exception e)
            {
                return "Failure: " + e.Message + " ---- InnerException: " + e.InnerException;
            }

        }

        public PartialViewResult ShowReservation(int id)
        {
            try
            {
                List<Client> Clients = new List<Client>();
                Clients = db.Clients.ToList();
                

                ViewBag.Reservation = new Reservation() { Room = db.Rooms.FirstOrDefault(x => x.Id.Equals(id)) };
                //ViewBag.Clients = Clients;
                

                return PartialView("PartialReservation", Clients);
            }
            catch (Exception)
            {
                return PartialView("Error");
            }

        }
        public string CreateRoom(string id, string quarto)
        {
            try
            {
               
                Room room = new Room()
                {
                    HotelId = Convert.ToInt32(id),
                    Type = Convert.ToInt32(quarto),
                };
                db.Rooms.Add(room);
                db.SaveChanges();
                return "Sucess";
            }catch(Exception e)
            {
                return "Failure; " + e.Message + e.InnerException;
            }
        }
        public PartialViewResult getClients()
        {
            return PartialView("PartialClient");
        }
        public PartialViewResult getProducts()
        {
            return PartialView("PartialProduct");
        }
        public PartialViewResult Search(int id)
        {

            

            Hotel hotel = db.Hotels.FirstOrDefault(x => x.Id.Equals(id));
                
            ViewBag.Hotel = hotel;
            return PartialView("PartialHotel");
            
            
        }
    }
}