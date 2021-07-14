using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Broadway._630.Web.ViewModel
{
    public class UserPasswordResetRequestViewModel : RequestViewModel
    {
        public string Username { get; set; }
    }

    public class UserPasswordResetResponseViewModel : ResponseViewModel
    {
    }
}