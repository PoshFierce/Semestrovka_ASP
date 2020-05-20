using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFilm.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public List<Film> filmsList { get; set; }
    }
}
