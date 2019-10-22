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
        public int ScoreID { get; set; }
        public int StudentNO { get; set; }
        public int SubjectNO { get; set; }
        public int Score { get; set; }
        public DateTime ExamDate { get; set; }
    }
}
