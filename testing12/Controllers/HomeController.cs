using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace testing12.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Verson"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Rutime"] = isMono ? "Mono123" : ".NET";
            ViewData["abc"] = "Test";
            return View();
        }
        public ActionResult Test()
        {
            var abc = "test";
            ViewData["abcTest"] = abc;
            return View();
        }
    }
}
