using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFilm.Data.Models;

namespace WebFilm.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Category> AllCategoriesHVM { get; set; }
    }
}
