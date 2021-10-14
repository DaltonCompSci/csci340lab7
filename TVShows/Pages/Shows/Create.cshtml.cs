using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TVShows.Data;
using TVShows.Models;

namespace TVShows.Pages.Shows
{
    public class CreateModel : PageModel
    {
        private readonly TVShows.Data.TVShowsContext _context;

        public CreateModel(TVShows.Data.TVShowsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Show Show { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Show.Add(Show);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
