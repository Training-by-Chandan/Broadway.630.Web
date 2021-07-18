using Broadway._630.Web.Service;
using Broadway._630.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Broadway._630.Web.Controllers
{
    [Route(Name = "New")]
    public class StudentController : Controller
    {
        private StudentService student = new StudentService();

        // GET: Student
        public ActionResult Index()
        {
            var data = student.GetAllStudents();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        [HttpPost]
        public ActionResult Create(StudentCreateRequestViewModel model)
        {
            //var res = student.CreateStudent(model);
            if (ModelState.IsValid)
            {
                //todo further processing here create user and student
            }
            else
            {
                //return errors
                Response.StatusCode = 403;
                var data = ModelState.Values.SelectMany(p => p.Errors).Select(p => new ErrorViewModel { Value = p.ErrorMessage });
                return Json(new ResponseViewModel() { Status = false, Data = data });
            }

            return PartialView("_Create");
        }

        public ActionResult Edit()
        {
            return PartialView("_Edit");
        }

        public ActionResult Details()
        {
            return PartialView("_Details");
        }
    }
}