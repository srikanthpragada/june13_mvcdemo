using mvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class ProductsController : Controller
    {
         
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var model = Products.GetProducts();
            return View(model);
        }


        public ActionResult Create()
        {
            Product model = new Product();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Product model)
        {
            // process model 
            return RedirectToAction("List");
        }


        [HttpPost]
        public ActionResult Edit(int id , Product product)
        {
            // update Product with data in product parameter 
            // return RedirectToAction("List");
            ViewBag.Message = "Updated Product Successfully!";
            return View(product);
        }

        public ActionResult Edit(int id)
        {
            var product = (from prod in Products.GetProducts()
                           where prod.Id == id
                           select prod).SingleOrDefault();
            return View(product);
        }
    }
}