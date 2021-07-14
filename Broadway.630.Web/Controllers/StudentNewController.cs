using Broadway._630.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Broadway._630.Web.Controllers
{
    public class StudentNewController : Controller
    {
        private Service.StudentService student = new Service.StudentService();

        public ActionResult Index()
        {
            var data = student.GetAllStudents();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentCreateRequestViewModel model)
        {
            if (ModelState.IsValid)
            {
                //todo send request to create the student

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                //todo do something here
            }
            else
            {
                //todo fetch the data from student service
                var data = student.GetStudentDetails(id.Value);
                return View(data);
            }
            return View();
        }

        public ActionResult Edit(StudentEditRequestViewModel model)
        {
            if (ModelState.IsValid)
            {
                //send request to the service to edit the record;
            }
            return View(model);
        }
    }
}