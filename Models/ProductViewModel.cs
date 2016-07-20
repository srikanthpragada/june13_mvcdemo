using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcdemo.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Nullable<decimal> TotalSales { get; set; }
    }
}