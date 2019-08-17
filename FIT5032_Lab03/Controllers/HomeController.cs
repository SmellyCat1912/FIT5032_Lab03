using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FIT5032_Lab03.HelloWorld;
using FIT5032_Lab03.Exercise;

namespace FIT5032_Lab03.Controllers
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
            Hello hello = new Hello();
            ViewBag.Message = hello.sayHello();

            ExampleDictionary studDic = new ExampleDictionary();
            ViewBag.Message2 = studDic.example();
            

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}