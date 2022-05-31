using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;


namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Доброго дня";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpGet]
        public ViewResult BorowsGuests()
        {
            GuestContext db = new GuestContext();
            return View(db.GuestResponse);
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse gt)
        {
            GuestContext db = new GuestContext();
            if (ModelState.IsValid)
            {
                db.GuestResponse.Add(gt);
                db.SaveChanges();
                return View("Thanks", gt);
            }
            else
            {
                return View();
            }
        }
    }
}