using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample1_1.Models;

namespace Sample1_1.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        public string SendHello(HelloPerson helloPerson)
        {
            return helloPerson.name.ToString() + ", hello!";
        }

        public ActionResult Hello()
        {
            return View();
        }
    }
}