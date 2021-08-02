using Broadway._630.Web.Models;
using Broadway._630.Web.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Broadway._630.Web.Controllers.API
{
    public class StudentAPIController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        [Authorize]
        public List<StudentListViewModel> GetAllStudents()
        {
            return db.Students.Select(p => new StudentListViewModel
            {
                Id = p.Id,
                Email = p.Email,
                Name = p.Name
            }).ToList();
        }

        [HttpPost]
        public IHttpActionResult CreateStudents(StudentCreateRequestViewModel model)
        {
            if (ModelState.IsValid && model != null)
            {
                return Ok();
            }
            else
            {
                var response = new StudentCreateResponseViewModel() { Status = false, Message = "Invalid data" };
                var responseStr = JsonConvert.SerializeObject(response);
                //var httpresponse = new HttpResponseMessage(HttpStatusCode.BadRequest);
                //httpresponse.Content= new StringContent(JsonConvert.SerializeObject(response));
                return BadRequest(responseStr);
            }
        }

        [HttpPut]
        public IHttpActionResult EditStudent(StudentCreateRequestViewModel model)
        {
            if (ModelState.IsValid && model != null)
            {
                return Ok();
            }
            else
            {
                var response = new StudentCreateResponseViewModel() { Status = false, Message = "Invalid data" };
                var responseStr = JsonConvert.SerializeObject(response);
                //var httpresponse = new HttpResponseMessage(HttpStatusCode.BadRequest);
                //httpresponse.Content= new StringContent(JsonConvert.SerializeObject(response));
                return BadRequest(responseStr);
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteStudent(StudentCreateRequestViewModel model)
        {
            if (ModelState.IsValid && model != null)
            {
                return Ok();
            }
            else
            {
                var response = new StudentCreateResponseViewModel() { Status = false, Message = "Invalid data" };
                var responseStr = JsonConvert.SerializeObject(response);
                //var httpresponse = new HttpResponseMessage(HttpStatusCode.BadRequest);
                //httpresponse.Content= new StringContent(JsonConvert.SerializeObject(response));
                return BadRequest(responseStr);
            }
        }

        public IHttpActionResult TestApi(List<People> list)
        {
            return Ok();
        }
    }

    public class People
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }

    public class Rootobject
    {
        public List[] list { get; set; }
    }

    public class List
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public Permanent Permanent { get; set; }
        public Permanent CurrentAddress { get; set; }
    }

    public class Permanent
    {
        public string MainAdress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}