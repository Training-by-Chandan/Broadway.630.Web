using Broadway._630.Web.Models;
using Broadway._630.Web.ViewModel;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Broadway._630.Web.Service
{
    public class StudentService
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public List<StudentListViewModel> GetAllStudents()
        {
            return db.Students.Select(p => new StudentListViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Email = p.Email,
                Username = p.User.UserName
            }).ToList();
        }

        public StudentCreateResponseViewModel CreateStudent(StudentCreateRequestViewModel model)
        {
            var res = new StudentCreateResponseViewModel();
            try
            {
                //todo create users
                if (!(db.Users.Any(u => u.UserName == model.Username)))
                {
                    var userStore = new UserStore<ApplicationUser>(db);
                    var userManager = new UserManager<ApplicationUser>(userStore);
                    var userToInsert = new ApplicationUser
                    {
                        UserName = model.Username,
                        Email = model.Email,
                        Avatar = model.Avatar
                    };
                    userManager.Create(userToInsert, model.Password);

                    userManager.AddToRole(userToInsert.Id, ConstString.Roles.Student);

                    var student = new Student()
                    {
                        Name = model.Name,
                        Address = model.Address,
                        Email = model.Email,
                        UserId = userToInsert.Id
                    };

                    db.Students.Add(student);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
            }

            return res;
        }

        public StudentEditRequestViewModel GetStudentDetailsForEdit(int id)
        {
            var data = db.Students.Find(id);
            if (data != null)
            {
                return new StudentEditRequestViewModel()
                {
                    Name = data.Name,
                    Id = data.Id,
                    Address = data.Address,
                    Email = data.Email,
                    Avatar = data.User == null ? "" : data.User.Avatar
                };
            }
            else
            {
                return null;
            }
        }

        public StudentDetailsViewModel GetStudentDetails(int id)
        {
            var data = db.Students.Find(id);
            if (data != null)
            {
                return new StudentDetailsViewModel()
                {
                    Name = data.Name,
                    Id = data.Id,
                    Address = data.Address,
                    Email = data.Email,
                    Username = data.User == null ? "" : data.User.UserName,
                    Avatar = data.User == null ? "" : data.User.Avatar
                };
            }
            else
            {
                return null;
            }
        }

        public StudentEditResponseViewModel EditStudent(StudentEditRequestViewModel model)
        {
            var res = new StudentEditResponseViewModel();
            try
            {
                var student = db.Students.Find(model.Id);
                if (student != null)
                {
                    student.Address = model.Address;
                    student.Email = model.Email;
                    student.Name = model.Name;
                    if (student.User != null && model.Avatar!=ConstString.Default.Avatar)
                    {
                        student.User.Avatar = model.Avatar;
                    }
                    //todo find the way to create the user first
                    db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    res.Status = true;
                    res.Message = "Student Updated Successfully";
                }
                else
                {
                    res.Message = "Student Not Found";
                }
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
            }

            return res;
        }
    }
}