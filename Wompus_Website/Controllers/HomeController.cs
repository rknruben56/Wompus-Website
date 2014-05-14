using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wompus_Website.Models;
using System.Data.Objects;

namespace Wompus_Website.Controllers
{
    public class HomeController : Controller
    {

        //Partial View for News in the Home Page
        [ChildActionOnly]
        public ActionResult _News()
        {
            WompusEntities db = new WompusEntities();
            var updates = from u in db.News select u;
            updates = updates.OrderByDescending(u => u.PublishTime);

            //Take only certain amount of items
            updates = updates.Take(2);

            return PartialView(updates);
        }

        //Partial View for the Sound in the Home Page
        public ActionResult _Music()
        {
            return PartialView();
        }

        //Partial View for the Shows in the Home Page
        [ChildActionOnly]
        public ActionResult _Shows()
        {
            WompusEntities db = new WompusEntities();
            var show = from s in db.Shows where EntityFunctions.DiffDays(s.ShowDate, DateTime.Now) < 0 orderby s.ShowDate select s;

            //Take only the one closest to the current date
            show = (IOrderedQueryable<Wompus_Website.Models.Show>) show.Take(1);

            return PartialView(show);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
