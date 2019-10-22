using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Pages.Grades
{
    public class Grades
    {
        [Key]
        [Display(Name = "Grade ID")]
        public int GradeID { get; set; }
        [Display(Name = "Grade NO")]
        public int GradeNO { get; set; }
        [Display(Name = "Grade Name")]
        public string GradeName { get; set; }
    }
}
