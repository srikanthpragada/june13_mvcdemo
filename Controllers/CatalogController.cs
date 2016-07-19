using mvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mvcdemo.Controllers
{
    public class CatalogController : ApiController
    {

        public  List<mvcdemo.Models.Product> Get()
        {
            return Products.GetProducts();
        }


    }
}
