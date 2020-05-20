using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFilm.Data.Interfaces;
using WebFilm.Data.Models;

namespace WebFilm.Data.Repository
{
    public class Film_Repository : IAllFilms
    {
        private readonly AppDBContent appDBContent;

        public Film_Repository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Film> GSFilms => appDBContent.GS_films.Include(c => c.Category);

        public Film getobjectCar(int filmID) => appDBContent.GS_films.FirstOrDefault(p => p.id == filmID);
    }
}
