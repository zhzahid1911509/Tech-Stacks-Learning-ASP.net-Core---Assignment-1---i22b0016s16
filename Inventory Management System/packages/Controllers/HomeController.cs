using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserData obj)

        {
            if (ModelState.IsValid)
            {
                CRUDAppDBEntities db = new CRUDAppDBEntities();
                db.UserDatas.Add(obj);
                db.SaveChanges();
            }
            return View(obj);
        }
    }
}