using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentSystem.Data;

namespace StudentSystem.Pages.Scores
{
    public class EditModel : PageModel
    {
        private readonly StudentSystem.Data.StudentSystemContext _context;

        public EditModel(StudentSystem.Data.StudentSystemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Scores Scores { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Scores = await _context.Scores.FirstOrDefaultAsync(m => m.ScoreID == id);

            if (Scores == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Scores).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScoresExists(Scores.ScoreID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ScoresExists(int id)
        {
            return _context.Scores.Any(e => e.ScoreID == id);
        }
    }
}
