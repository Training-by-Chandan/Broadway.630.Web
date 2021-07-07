using Broadway._630.Web.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Broadway._630.Web.Controllers
{
    public class StudentController : Controller
    {
        private StudentService student = new StudentService();

        // GET: Student
        public ActionResult Index()
        {
            var data = student.GetAllStudents();
            return View(data);
        }
    }
}