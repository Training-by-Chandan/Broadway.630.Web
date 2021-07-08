using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Broadway._630.Web.ViewModel
{
    public class StudentCreateRequestViewModel : RequestViewModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
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
    }
}