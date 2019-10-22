using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentSystem.Data;

namespace StudentSystem.Pages.Grades
{
    public class CreateModel : PageModel
    {
        private readonly StudentSystem.Data.StudentSystemContext _context;

        public CreateModel(StudentSystem.Data.StudentSystemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Grades Grades { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Grades.Add(Grades);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
