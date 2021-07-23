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
        [System.Web.Http.HttpGet]
        public object Index()
        {
            try
            {
                throw new NotImplementedException("This function is not implemented");
            }
            catch (Exception)
            {
            }
            return null;
        }
    }
}