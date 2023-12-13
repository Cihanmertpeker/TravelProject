using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    public class LoginController : Controller
    {
        Context context = new Context();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var loginInfo=context.Admins.FirstOrDefault(x=>x.AppUser==admin.AppUser && x.Password==admin.Password);
            if (loginInfo != null) 
            {
                FormsAuthentication.SetAuthCookie(loginInfo.AppUser, false);
                Session["AppUser"]=loginInfo.AppUser.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
          
        }
        public ActionResult Logout()
        { 
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}