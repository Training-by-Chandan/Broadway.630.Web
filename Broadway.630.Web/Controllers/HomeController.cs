using Broadway._630.Web.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Broadway._630.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id = 1)
        {
            if (id == 0)
            {
                return null;
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            var data = ControllerService.GetAll();

            return View(data);
        }
    }
}