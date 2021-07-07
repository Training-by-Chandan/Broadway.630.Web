using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Broadway._630.Web.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Max value can be upto 50 characters.")]
        [Display(Name = "Student Name", GroupName = "Basic")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        [Required]//db and view
        [MaxLength(50)]//db and view
        [Display(Name = "Student Email", GroupName = "Basic")]
        [DataType(DataType.EmailAddress)]// view
        public string Email { get; set; }

        public string Username { get; set; }

        [ForeignKey("Username")]
        public virtual ApplicationUser User { get; set; }
    }
}