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
        public int GradeID { get; set; }
        public int GradeNO { get; set; }
        public string GradeName { get; set; }
    }
}
