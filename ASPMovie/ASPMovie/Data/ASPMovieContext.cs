using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPMovie.Models;

namespace ASPMovie.Data
{
    public class ASPMovieContext : DbContext
    {
        public ASPMovieContext (DbContextOptions<ASPMovieContext> options)
            : base(options)
        {
        }

        public DbSet<ASPMovie.Models.Movie> Movie { get; set; }
    }
}
