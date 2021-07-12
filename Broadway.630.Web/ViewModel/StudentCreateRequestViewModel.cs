using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Broadway._630.Web.ViewModel
{
    public class StudentCreateRequestViewModel : RequestViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Compare password is required")]
        [Compare("Password", ErrorMessage = "Password and Compare Password does not match")]
        public string ConfirmPassword { get; set; }
    }

    public class StudentCreateResponseViewModel : ResponseViewModel
    {
    }

    public class RequestViewModel
    {
    }

    public class ResponseViewModel
    {
        public bool Status { get; set; } = false;
        public string Message { get; set; }

        public object Data { get; set; }
    }

    public class ErrorViewModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}