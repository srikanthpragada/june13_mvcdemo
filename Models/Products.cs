using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcdemo.Models
{
    public class Products
    {
        public static List<Product> GetProducts()
        {
            List<Product> prods = new List<Product>
            {
                new Product { Id = 1, Name = "iPhone6", Price = 45000, Qoh = 10 },
                new Product { Id = 2, Name = "iPad Air 2 64 GB WIFI + CELLURAR", Price = 56000, Qoh = 5 },
                new Product { Id = 3, Name = "Google Nexus 6p", Price = 38000, Qoh = 20 }
            };

            return prods;
        }
    }
}