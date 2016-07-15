using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class AjaxController : Controller
    {
        List<String> names = new List<String>()
            {  "Anders",
               "Scott Guthrie",
               "Joe Stagner",
               "Bob Tabour",
               "Scott Allen"
            };


        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }

        public String Now()
        {
            return DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        [HttpPost]
        public ActionResult Names(String pattern)
        {
            var selnames = names.Where(n => n.ToUpper().Contains(pattern.ToUpper()));
            return PartialView("Names", selnames);
        }
    }
}