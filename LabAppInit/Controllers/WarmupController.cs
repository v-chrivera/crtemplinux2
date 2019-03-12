using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace LabAppInit.Controllers
{
    public class WarmupController : Controller
    {
        static DateTime startupTimestamp = DateTime.Now;
        // GET: Warmup
        public string Index()
        {
            Thread.Sleep(60000);
            return "Warmed up";
        }

        public string NoSleep()
        {
            TimeSpan differnce = DateTime.Now - startupTimestamp;

            if (differnce < TimeSpan.FromSeconds(80))
            {
                Response.StatusCode = 502;
            }
            return "Warming up";
        }
    }
}