using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcdemo.Models
{
    public class SaleViewModel
    {
        public int Invno { get; set; }
        public string ProdName { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<DateTime> SoldOn { get; set; }
    }
}