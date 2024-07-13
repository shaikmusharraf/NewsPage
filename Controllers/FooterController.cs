using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsPage.Controllers
{
    public class FooterController : Controller
    {
        // GET: Footer
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult PrivacyPolicy()
        {
            return View();
        }
        public ActionResult TermsOfServices()
        {
            return View();
        }

        public ActionResult Careers()
        {
            return View("ContactUs");
        }

        public ActionResult Help() 
        {
            return View("ContactUs");
        
        }

    }
}