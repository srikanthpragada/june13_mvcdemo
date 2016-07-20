using mvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class DBProductsController : Controller
    {
        
        public ActionResult Index()
        {
            msdbEntities ctx = new msdbEntities();
            var products = from p in ctx.Products
                        select new ProductViewModel 
                        {
                            Id = p.ProdId,
                            Name = p.ProdName,
                            TotalSales = p.Sales.Sum( s => s.Amount) 
                        };

            return View(products);
        }

        public ActionResult SalesReport()
        {
            msdbEntities ctx = new msdbEntities();
            return View(ctx.Products.ToList<Product>());
        }
    }
}