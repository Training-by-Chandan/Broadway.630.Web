using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Broadway._630.Web.ViewModel
{
    public class StudentEditRequestViewModel : RequestViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        private string _avatar;

        public string Avatar
        {
            get
            {
                return string.IsNullOrWhiteSpace(_avatar) ? ConstString.Default.Avatar : _avatar;
            }
            set
            {
                _avatar = value;
            }
        }
    }

    public class StudentEditResponseViewModel : ResponseViewModel
    {
    }

    public class StudentDetailsViewModel : StudentEditRequestViewModel
    {
        public string Username { get; set; }
    }
}