using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewsPage.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace NewsPage.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();

        }

        [HttpPost]

        public ActionResult Login(Models.Membership model)
        {
            using (var con=new NewsPageEntities1())
            {
                bool isValid=con.User.Any(o=>o.UserName == model.UserName&&o.Password==model.Password);
                if(isValid)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid Username and password");
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");

        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(User model)
        {
            using (var con=new NewsPageEntities1())
            {
                con.User.Add(model);
                con.SaveChanges();

            }
            return RedirectToAction("Login");
        }



    }
}
/*
        [HttpPost]
        public ActionResult Login(Membership model)
        {
            using (var con = new NewsPageEntities())
            {
                bool isValid = con.User.Any(o => o.UserName == model.UserName && o.Password == model.Password);
                if (isValid)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, true);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid Username and Password");
                return View();
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(User model)
        {
            using (var con=new NewsPageEntities())
            {
                con.User.Add(model);
                con.SaveChanges();

            }

            return RedirectToAction("Login");
        }
*/