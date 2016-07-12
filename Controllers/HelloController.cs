using mvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            ViewBag.Today = DateTime.Now.ToString("dd-MM-yyyy  HH:mm:ss");
            return View();
        }


        public ActionResult Info()
        {
            Person p = new Person { Name = "Srikanth Pragada", Mobile = "9059057000" };
            return View(p);
        }
    }
}

