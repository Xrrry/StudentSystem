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
    public class IndexModel : PageModel
    {
        private readonly StudentSystem.Data.StudentSystemContext _context;

        public IndexModel(StudentSystem.Data.StudentSystemContext context)
        {
            _context = context;
        }

        public IList<Subjects> Subjects { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public async Task OnGetAsync()
        {

            var st = from m in _context.Subjects
                     select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                st = st.Where(s => s.SubjectName.Contains(SearchString));
            }

            Subjects = await st.ToListAsync();
        }
    }
}
