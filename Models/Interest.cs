using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcdemo.Models
{
    public class Interest
    {
        [Range(10000,1000000, ErrorMessage ="Invalid Loan Amount. Valid Range is 10,000  to 10,00,0000")]
        public double Amount { get; set; }
        public double Rate { get; set; }
        public double Result { get; set; }
        [Range(6,60, ErrorMessage ="Valid range is from 6 to 60 months")]
        public double Period { get; set; }

    }
}