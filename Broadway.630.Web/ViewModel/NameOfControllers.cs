using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Broadway._630.Web.ViewModel
{
    public class NameOfControllers
    {
        public string Name { get; set; }
        public bool isAuthorised { get; set; }
        public List<NameOfActions> Actions { get; set; }
    }

    public class NameOfActions
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string ReturnType { get; set; }
    }
}