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
                Username = p.User.Id
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
                    var userToInsert = new ApplicationUser { UserName = model.Username, Email = model.Email };
                    userManager.Create(userToInsert, model.Password);

                    userManager.AddToRole(userToInsert.Id, ConstString.Roles.Student);

                    var student = new Student()
                    {
                        Name = model.Name,
                        Address = model.Address,
                        Email = model.Email,
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

        public StudentEditRequestViewModel GetStudentDetails(int id)
        {
            var data = db.Students.Find(id);
            if (data != null)
            {
                return new StudentEditRequestViewModel()
                {
                    Name = data.Name,
                    Id = data.Id,
                    Address = data.Address,
                    Email = data.Email
                };
            }
            else
            {
                return null;
            }
        }
    }
}