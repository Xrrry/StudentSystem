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
    public class IndexModel : PageModel
    {
        private readonly StudentSystem.Data.StudentSystemContext _context;

        public IndexModel(StudentSystem.Data.StudentSystemContext context)
        {
            _context = context;
        }

        public IList<Scores> Scores { get;set; }

        public async Task OnGetAsync()
        {
            Scores = await _context.Scores.ToListAsync();
        }
    }
}
