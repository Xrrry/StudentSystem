using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Pages.Subjects
{
    public class Subjects
    {
        [Key]
        [Display(Name = "Subject NO")]
        public int SubjectNO { get; set; }
        [Display(Name = "SubjectName")]
        public string SubjectName { get; set; }
        [Display(Name = "Class Hour")]
        public int ClassHour { get; set; }
        [Display(Name = "Grade NO")]
        public int GradeNO { get; set; }

    }
}
