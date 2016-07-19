using mvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class SalesController : Controller
    {
       
        public ActionResult Index()
        {
            msdbEntities ctx = new msdbEntities();
            var sales = from s in ctx.Sales
                        select new SaleViewModel
                        {
                            Invno = s.Invno,
                            ProdName = s.Product.ProdName,
                            Amount = s.Amount,
                            Qty = s.Qty,
                            SoldOn = s.TransDate
                        };

            return View(sales);
        }
    }
}