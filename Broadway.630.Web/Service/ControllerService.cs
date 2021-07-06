using Broadway._630.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Broadway._630.Web.Service
{
    public class ControllerService
    {
        public static List<NameOfControllers> GetAll()
        {
            var asm = Assembly.GetExecutingAssembly();
            var data = asm.GetTypes()
                .Where(p => typeof(Controller).IsAssignableFrom(p))
                .Select(p => new NameOfControllers
                {
                    Name = p.Name,
                    isAuthorised = p.GetCustomAttribute<AuthorizeAttribute>() != null
                });
            return data.ToList();
        }
    }
}