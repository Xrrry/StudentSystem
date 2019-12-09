using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Pages.Students
{
    public class Students
    {
        [Key]
        [Display(Name = "Student NO")]
        public int StudentNO { get; set; }
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        [Display(Name = "Id Card NO")]
        public string IdCardNO { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        [Display(Name = "Grade NO")]
        public int GradeNO { get; set; }
    }
}
