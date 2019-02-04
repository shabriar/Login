using LoginPortal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginPortal.Controllers
{
    public class UserController : Controller
    {
        LogInDbContext context = new LogInDbContext();
        // GET: User
  
        public ActionResult Index()
        {
            ViewBag.BikeList = context.Bikes.ToList();
            User obj =new  User();
            return View(obj);
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

     
        public ActionResult ShowUsers()
        {
            var UsersList = context.Users.Where(x=>x.IsDeleted!=true).ToList();       
            return View(UsersList);
        }

        [HttpGet]
        public ActionResult delete(int id)
        {
            var obj= context.Users.Single(x => x.Id == id);
            obj.IsDeleted = true;
            context.SaveChanges();
            return RedirectToAction("ShowUsers");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var UserAllData = context.Users.Find(id);

            return View(UserAllData);
        }
        [HttpPost]
        public ActionResult Edit(User x)
        {
            var userEntry = context.Users.Find(x.Id);
            userEntry.UserEmail = x.UserEmail;
            userEntry.UserName = x.UserName;
            userEntry.UserPhone = x.UserPhone;
            userEntry.UserAddress = x.UserAddress;
            
            

            context.Entry(userEntry).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("ShowUsers");
        }
    }
}