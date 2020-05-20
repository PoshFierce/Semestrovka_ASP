using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFilm.Data.Models;

namespace WebFilm.ViewModels
{
    public class FilmsListViewModel
    {
        public IEnumerable<Film> getAllFilms { get; set; }
        public string currCategory { get; set; }
    }
}
