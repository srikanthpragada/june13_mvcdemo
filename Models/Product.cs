﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcdemo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public decimal Price { get; set; }
        public int Qoh { get; set; }
    }
}