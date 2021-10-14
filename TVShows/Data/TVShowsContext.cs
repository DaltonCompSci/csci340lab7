using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TVShows.Models;

namespace TVShows.Data
{
    public class TVShowsContext : DbContext
    {
        public TVShowsContext (DbContextOptions<TVShowsContext> options)
            : base(options)
        {
        }

        public DbSet<TVShows.Models.Show> Show { get; set; }
    }
}
