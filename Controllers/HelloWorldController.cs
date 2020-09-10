using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_FinalProject.Controllers
{
    public class HelloWorldController : Controller
    {
        // The controller methods will return a string of HTML
        // GET: /HelloWorld/ 
        //Index is the default method that will be called on a controller if one is not explicitly specified.
       
        //public string Index()
        //{
        //    return "This is my <b>default</b> action...";
        //}

        public ActionResult Index()
        {
            //uses a view template to generate an HTML response to the browser.
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            //the ViewBag object contains data that will be passed to the view automatically. 
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}