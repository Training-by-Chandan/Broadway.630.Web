using Broadway._630.Web.Models;
using Broadway._630.Web.ViewModel;
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
    }
}