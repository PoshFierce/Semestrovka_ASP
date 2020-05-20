using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFilm.Data.Models;

namespace WebFilm.Data.Interfaces
{
    public interface IFilmsCategory
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
