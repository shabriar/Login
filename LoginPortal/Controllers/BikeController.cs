using LoginPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginPortal.Controllers
{
    public class BikeController : Controller
    {
        LogInDbContext context = new LogInDbContext();
        // GET: Bike
        
        public ActionResult Index()
        {
          
            Bikes obj = new Bikes();
            return View(obj);
        }
        [HttpPost]
        public ActionResult Index(Bikes obj)
        {
            context.Bikes.Add(obj);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ShowAllBike()
        {
            var BikeList = context.Bikes;
            return View(BikeList);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var BikeList = context.Bikes.Find(id);
            context.Bikes.Remove(BikeList);
            context.SaveChanges();

            return RedirectToAction("ShowAllBike");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return RedirectToAction("ShowAllBike");
        }
    }
}