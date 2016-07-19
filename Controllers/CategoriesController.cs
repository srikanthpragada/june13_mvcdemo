using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            inventoryEntities ctx = new inventoryEntities(); // DbContext
            var cats = ctx.Categories.OrderBy(c => c.CatDesc);   // DbSet<Category>
            return View(cats);
        }

        public ActionResult Create()
        {
            var cat = new Category();
            return View(cat);
        }

        [HttpPost]
        public ActionResult Create(Category cat)
        {
            // add a row to Categories table using EF
            try
            {
                inventoryEntities ctx = new inventoryEntities(); // DbContext
                ctx.Categories.Add(cat);
                ctx.SaveChanges();
                ViewBag.Message = "Added category successfully!";

            }
            catch(Exception ex)
            {
                ViewBag.Message = "Error --> " + ex.Message;
            }
            return View(cat);
        }

        public ActionResult Delete(string id)
        {
            try
            {
                inventoryEntities ctx = new inventoryEntities(); // DbContext
                var category = ctx.Categories.Find(id); // SQL select 
                ctx.Categories.Remove(category);  // SQL delete
                ctx.SaveChanges();
                TempData ["Message"] = "Deleted category [" + category.CatDesc + "] successfully!";
            }
            catch(Exception ex)
            {
               TempData["Message"] = "Sorry! Unable to delete selected category! Error --> " + ex.Message ;     
            }
            return RedirectToAction("Index");
        }


        public ActionResult Edit(string id)
        {
           inventoryEntities ctx = new inventoryEntities(); // DbContext
           var category = ctx.Categories.Find(id); // SQL select 
           return View(category);

        }

        [HttpPost]
        public ActionResult Edit(Category cat)
        {
            inventoryEntities ctx = new inventoryEntities(); // DbContext
            var category = ctx.Categories.Find(cat.CatCode); // SQL select 
            category.CatDesc = cat.CatDesc;
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string pattern)
        {
            inventoryEntities ctx = new inventoryEntities(); // DbContext
            var cats = from cat in ctx.Categories
                       where cat.CatCode.Contains(pattern) || cat.CatDesc.Contains(pattern)
                       select cat;

            return PartialView("SearchResult", cats);
        }
    }
}
