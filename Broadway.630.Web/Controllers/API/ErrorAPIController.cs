using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Broadway._630.Web.Controllers.API
{
    public class ErrorAPIController : ApiController
    {
        // GET: ErrorAPI
        public object Index()
        {
            var responsemessage = new { status = false, message = "Unauthenticated" };
            HttpContext.Current.Response.StatusCode = 401;
            return responsemessage;
        }
    }
}