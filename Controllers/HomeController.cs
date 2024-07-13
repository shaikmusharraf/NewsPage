using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsPage.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult India()
        {
            return View();
        }
        public ActionResult epaper()
        {
            return View();
        }
        public ActionResult World()
        {
            return View();
        }
        public ActionResult Sports()
        {
            return View();
        }
        public ActionResult Science()
        {
            throw new Exception();
        }
        public ActionResult Business()
        {
            return View();
        }
        public ActionResult Politics()
        {
            return View();
        }
        public ActionResult Health()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}