using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mvcdemo.Controllers
{

    public class MessagesController : ApiController
    {
        private string[] messages =
            {"Failing to plan is planning to fail",
             "Winners never quit, quitters never win",
             "What you give is what you get"};

        public List<string> get()
        {
            return messages.ToList<string>();
        }
        public String get(int id)
        {
            return messages[id - 1];
        }

    }
}
