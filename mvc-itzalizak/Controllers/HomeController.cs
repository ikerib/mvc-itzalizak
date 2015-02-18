using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_itzalizak.Controllers
{
    public class HomeController : Controller
    {
        public void Itzali()
        {
            string arg = "/s /f /t 0";

            System.Diagnostics.Process.Start("shutdown", arg);
        }
    }
}
