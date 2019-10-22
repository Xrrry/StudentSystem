using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentSystem.Pages.Grades;
using StudentSystem.Pages.Students;
using StudentSystem.Pages.Subjects;
using StudentSystem.Pages.Scores;

namespace StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext (DbContextOptions<StudentSystemContext> options)
            : base(options)
        {
        }

        public DbSet<StudentSystem.Pages.Grades.Grades> Grades { get; set; }

        public DbSet<StudentSystem.Pages.Students.Students> Students { get; set; }

        public DbSet<StudentSystem.Pages.Subjects.Subjects> Subjects { get; set; }

        public DbSet<StudentSystem.Pages.Scores.Scores> Scores { get; set; }
    }
}
