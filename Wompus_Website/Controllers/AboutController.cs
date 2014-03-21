using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wompus_Website.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /About/

        public ActionResult Index()
        {
            ViewBag.Message = "Check here to learn about your favorite band!";

            return View();
        }

    }
}
