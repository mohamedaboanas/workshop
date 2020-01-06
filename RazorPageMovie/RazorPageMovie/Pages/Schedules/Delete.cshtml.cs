﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageMovie.Models;

namespace RazorPageMovie.Pages.Schedules
{
    public class DeleteModel : PageModel
    {
        private readonly MovieContext _context;

        public DeleteModel(MovieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Schedule Schedule { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Schedule = await _context.Schedules.SingleOrDefaultAsync(m => m.Id == id);
            if (Schedule == null)
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
            Schedule = await _context.Schedules.FindAsync(id);
            if (Schedule != null)
            {
                _context.Schedules.Remove(Schedule);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}