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
    }

    public class StudentEditResponseViewModel : ResponseViewModel
    {
    }
}