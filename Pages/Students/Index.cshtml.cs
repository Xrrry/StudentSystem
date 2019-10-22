﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public IList<Students> Students { get;set; }

        public async Task OnGetAsync()
        {
            Students = await _context.Students.ToListAsync();
        }
    }
}
