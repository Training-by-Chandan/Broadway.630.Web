using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Broadway._630.Web
{
    public class ConstString
    {
        public class Roles
        {
            public const string Admin = "Admin";
            public const string Student = "Student";
            public const string Teacher = "Teacher";
        }

        public class Default
        {
            public const string Avatar = "/admintheme/dist/img/avatar.png";
        }

        public class Sessions
        {
            public const string StudentKey = "StudentKey";
        }
        public class Cookies
        {
            public const string StudentKey = "StudentKey";
        }
    }
}