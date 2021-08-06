using Broadway._630.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Broadway._630.Web.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult ReportTemplate(string path)
        {
            var rptInfo = new ReportInfo
            {
                ReportURL = "../../Reports/Report1.aspx?path=" + path,
            };

            return View(rptInfo);
        }
    }
}