using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFilm.Data.Models
{
    public class Film
    {
        public int id { get; set; }
        public string nameFilm { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
