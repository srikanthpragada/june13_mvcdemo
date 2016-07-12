using mvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class InterestController : Controller
    {
        // Handles Get request
        public ActionResult Index()
        {
            Interest model = new Interest { Rate = 11 };
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Interest model)
        {
            model.Result = model.Amount * model.Rate / 100; 
            return View(model);
        }

        // Handles Get request
        public ActionResult Rate()
        {
            Interest model = new Interest();
            return View(model);
        }

        // Handles Get request
        [HttpPost]
        public ActionResult Rate(Interest model)
        {
            model.Rate = model.Period < 12 ? 10 : 11;
            return View(model);
        }
    }
}