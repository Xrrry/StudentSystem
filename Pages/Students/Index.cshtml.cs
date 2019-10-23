using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentSystem.Data;

namespace StudentSystem.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentSystem.Data.StudentSystemContext _context;

        public IndexModel(StudentSystem.Data.StudentSystemContext context)
        {
            _context = context;
        }

        public IList<Students> Students { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public async Task OnGetAsync()
        {
            
            var st = from m in _context.Students
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                st = st.Where(s => s.UserName.Contains(SearchString));
            }

            Students = await st.ToListAsync();
        }
    }
}
