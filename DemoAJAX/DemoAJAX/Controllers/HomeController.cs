using DemoAJAX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoAJAX.Controllers
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
            var population = GetProducts();
            return Json(population, JsonRequestBehavior.AllowGet);
           
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
           // getProducts();
            return View("getProducts",getProducts());
        }

        private List<Products> GetProducts()
        {
            var ProdList = new List<Products>
            {
                new Products
                {
                    PID = "1",
                   pName = "Chinese saman",

                },
                new Products
                {
                     PID  =" 2",
                    pName = "Indaia",

                },
                new Products
                {
                    PID = "3",
                   pName = "Chinese saman",
                },
                new Products
                {
                    PID = "6",
                   pName = "Chinese saman",
                }
            };

            return ProdList;

        }
        public ActionResult getProducts()
        {
            var population = GetProducts();
            return Json(population, JsonRequestBehavior.AllowGet);
        }
    }
}