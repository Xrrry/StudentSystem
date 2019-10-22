using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentSystem.Data;

namespace StudentSystem.Pages.Grades
{
    public class DeleteModel : PageModel
    {
        private readonly StudentSystem.Data.StudentSystemContext _context;

        public DeleteModel(StudentSystem.Data.StudentSystemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Grades Grades { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Grades = await _context.Grades.FirstOrDefaultAsync(m => m.GradeID == id);

            if (Grades == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Grades = await _context.Grades.FindAsync(id);

            if (Grades != null)
            {
                _context.Grades.Remove(Grades);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
