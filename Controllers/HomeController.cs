using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Authentication_Authorization.Models;

namespace Authentication_Authorization.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

     
        public ActionResult Contact(User user)
        {
            if(!ModelState.IsValid)
            {
                return View("Login", user);
            }
            user.l.Add(user);
            ViewBag.Message = "Your contact page.";
            //User u = new User();
           // if(ModelState.IsValid)
            return View("Loggedin",user);
            
        }
    }
}