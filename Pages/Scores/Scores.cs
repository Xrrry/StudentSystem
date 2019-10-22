using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Pages.Scores
{
    public class Scores
    {
        [Key]
        [Display(Name = "Score ID")]
        public int ScoreID { get; set; }
        [Display(Name = "Student NO")]
        public int StudentNO { get; set; }
        [Display(Name = "Subject NO")]
        public int SubjectNO { get; set; }
        public int Score { get; set; }
        [Display(Name = "Exam Date")]
        public DateTime ExamDate { get; set; }
    }
}
