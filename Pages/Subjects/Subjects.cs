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
        public int SubjectID { get; set; }
        public int SubjectNO { get; set; }
        public string SubjectName { get; set; }
        public int ClassHour { get; set; }
        public int GradeNO { get; set; }

    }
}
