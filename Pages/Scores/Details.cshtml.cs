using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentSystem.Data;

namespace StudentSystem.Pages.Scores
{
    public class DetailsModel : PageModel
    {
        private readonly StudentSystem.Data.StudentSystemContext _context;

        public DetailsModel(StudentSystem.Data.StudentSystemContext context)
        {
            _context = context;
        }

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
    }
}
