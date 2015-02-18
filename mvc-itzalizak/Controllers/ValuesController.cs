using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mvc_itzalizak.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public void Get()
        //public IEnumerable<string> Get()
        {
            string arg = "/s /f /t 0";

            System.Diagnostics.Process.Start("shutdown", arg);
        }
    }
}