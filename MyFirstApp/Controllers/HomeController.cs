using System;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View("OurCompanyProducts");
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult GetEmpName(int Empid)
        {
            var employees = new[]
            {
                new{Empid=1,EmpName="Scott",Salary=8000},
                new{Empid=2,EmpName="Smith",Salary=2540},
                new{Empid=2,EmpName="Vivek",Salary=1500},
            };

            string matchEmpName = null;
            foreach(var item in employees)
            {
                if (item.Empid == Empid)
                {
                    matchEmpName = item.EmpName;
                }
            }
            return Content(matchEmpName,"text/plain");
        }
        public ActionResult RequestExample()
        {
            ViewBag.Url = Request.Url;
            ViewBag.PhysicalApplicationPath = Request.PhysicalApplicationPath;
            ViewBag.Path = Request.Path;
            ViewBag.Browser = Request.Browser.Type;
            ViewBag.QueryString = Request.QueryString["n"];
            ViewBag.Headers = Request.Headers;
            ViewBag.HttpMethod = Request.HttpMethod;

            return View();
        }
    }
}



