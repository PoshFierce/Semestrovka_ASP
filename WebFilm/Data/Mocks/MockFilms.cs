using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFilm.Data.Interfaces;
using WebFilm.Data.Models;

namespace WebFilm.Data.Mocks
{
    public class MockFilms : IAllFilms
    {
        private readonly IFilmsCategory _categoryFilms = new MockCategory();
        public IEnumerable<Film> GSFilms {
            get 
            {
                return new List<Film>
                {
                    new Film {
                        nameFilm = "Астрал", 
                        shortDesc = "Ужастик с интересным и продуманным сюжетом, много отсылок к эзотерике", 
                        longDesc = "", 
                        img = "/img/Astral.jpg", 
                        Category = _categoryFilms.AllCategories.First()},

                    new Film {nameFilm = "V - значит Вендетта", 
                        shortDesc = "Один из фильмов Марвела, который не связан с основными. Про антиутопию в государстве.",
                        longDesc = "", 
                        img = "/img/vendetta.jpg",
                        Category = _categoryFilms.AllCategories.ElementAt(8)},

                    new Film {nameFilm = "Горько!",
                        shortDesc = "Российская комедия, про гулянку на свадьбе",
                        longDesc = "",
                        img = "/img/Gorko.jpg",
                        Category = _categoryFilms.AllCategories.ElementAt(1)},

                    new Film {nameFilm = "Последний охотник на ведьм",
                        shortDesc = "Челик охотится на ведьм в нашем мире",
                        longDesc = "",
                        img = "/img/LHW.jpg",
                        Category = _categoryFilms.AllCategories.ElementAt(9)},

                    new Film {
                        nameFilm = "Нелюбовь",
                        shortDesc = "Очень тяжелый и жизненный фильм про быт в Российских семьях",
                        longDesc = "", 
                        img = "/img/Notlove.jpeg",
                        Category = _categoryFilms.AllCategories.ElementAt(2)},

                    new Film {nameFilm = "Три метра над уровнем неба",
                        shortDesc = "Романтика, любовь, крутой челик на байке, невинная девочка из правельной семьи", 
                        longDesc = "", 
                        img = "/img/TMUS.jpg",
                        Category = _categoryFilms.AllCategories.ElementAt(4)}
                };
            }
        }

        public Film getobjectCar(int filmID)
        {
            throw new NotImplementedException();
        }
    }
}
