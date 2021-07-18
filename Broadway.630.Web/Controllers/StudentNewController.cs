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
                //todo upload the file and add it to the asset folder
                var file = Request.Files[0];
                if (file.ContentLength > 0)
                {
                    var ext = System.IO.Path.GetExtension(file.FileName);
                    var filenameTobeSaved = Guid.NewGuid().ToString() + ext;
                    var path = "/Assets/Avatar/" + filenameTobeSaved;

                    file.SaveAs(Server.MapPath(path));
                    model.Avatar = path;
                }
                var res = student.CreateStudent(model);
                if (res.Status)
                {
                    return RedirectToAction("Index");
                }
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
                var data = student.GetStudentDetailsForEdit(id.Value);
                return View(data);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(StudentEditRequestViewModel model)
        {
            if (ModelState.IsValid)
            {
                var file = Request.Files[0];
                if (file.ContentLength > 0)
                {
                    var ext = System.IO.Path.GetExtension(file.FileName);
                    var filenameTobeSaved = Guid.NewGuid().ToString() + ext;
                    var path = "/Assets/Avatar/" + filenameTobeSaved;

                    file.SaveAs(Server.MapPath(path));

                    if (model.Avatar != ConstString.Default.Avatar)
                    {
                        System.IO.File.Delete(Server.MapPath(model.Avatar));
                    }

                    model.Avatar = path;
                }
                //send request to the service to edit the record;
                var res = student.EditStudent(model);
                if (res.Status)
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", res.Message);
            }
            return View(model);
        }

        public ActionResult Details(int? id)
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
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route(Name = "New")]
        public ActionResult AddToSession(int? id)
        {
            if (id != null)
            {
                var obj = Session[ConstString.Sessions.StudentKey] as List<int>;
                if (obj == null)
                    obj = new List<int>();

                obj.Add(id.Value);
                Session.Add(ConstString.Sessions.StudentKey, obj);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddToCookie(int? id)
        {
            if (id != null)
            {
                var cookie = Request.Cookies[ConstString.Cookies.StudentKey].Value;
                var studentCookie = new HttpCookie(ConstString.Cookies.StudentKey, cookie + "," + id.Value.ToString());
                studentCookie.Expires = DateTime.Now.AddDays(365);
                Response.Cookies.Add(studentCookie);
            }
            return RedirectToAction("Index");
        }
    }
}