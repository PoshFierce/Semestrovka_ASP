using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebFilm.Data.Models;

namespace WebFilm.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
        }

        public DbSet<Film> GS_films { get; set; }
        public DbSet<Category> GS_categories { get; set; }

    }
}
