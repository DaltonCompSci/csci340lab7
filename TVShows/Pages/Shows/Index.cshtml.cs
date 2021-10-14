using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TVShows.Data;
using TVShows.Models;

namespace TVShows.Pages.Shows
{
    public class IndexModel : PageModel
    {
        private readonly TVShows.Data.TVShowsContext _context;

        public IndexModel(TVShows.Data.TVShowsContext context)
        {
            _context = context;
        }

        public IList<Show> Show { get;set; }

        public async Task OnGetAsync()
        {
            Show = await _context.Show.ToListAsync();
        }
    }
}
