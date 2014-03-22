using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wompus_Website.Models;

namespace Wompus_Website.Controllers
{
    public class HomeController : Controller
    {

        //Partial View for News in the Home Page
        [ChildActionOnly]
        public ActionResult _News()
        {
            NewsDBContext db = new NewsDBContext();
            var updates = from u in db.Updates select u;
            updates = updates.OrderByDescending(u => u.PublishTime);

            //Take only certain amount of items
            updates = updates.Take(1);

            return PartialView(updates);
        }

        //Partial View for the Sound in the Home Page
        public ActionResult _Music()
        {
            ViewBag.Message = "Music Will go here!";

            return PartialView();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
