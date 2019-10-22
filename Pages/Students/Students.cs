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
        public int StudentID { get; set; }
        public int StudentNO { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string IdCardNO { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int GradeNO { get; set; }
    }
}
