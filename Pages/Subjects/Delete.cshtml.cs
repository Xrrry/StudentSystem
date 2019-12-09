using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentSystem.Data;

namespace StudentSystem.Pages.Subjects
{
    public class DeleteModel : PageModel
    {
        private readonly StudentSystem.Data.StudentSystemContext _context;

        public DeleteModel(StudentSystem.Data.StudentSystemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Subjects Subjects { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Subjects = await _context.Subjects.FirstOrDefaultAsync(m => m.SubjectNO == id);

            if (Subjects == null)
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

            Subjects = await _context.Subjects.FindAsync(id);

            if (Subjects != null)
            {
                _context.Subjects.Remove(Subjects);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
