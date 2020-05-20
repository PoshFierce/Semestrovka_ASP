using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFilm.Data.Interfaces;
using WebFilm.Data.Models;

namespace WebFilm.Data.Mocks
{
    public class MockCategory : IFilmsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Страшилки"}, //0
                    new Category { categoryName = "Посмеяться"}, //1
                    new Category { categoryName = "Смотерть с серьезным лицом, морально-тяжелые"}, //2
                    new Category { categoryName = "Смотреть с умным видом, психологические"}, //3
                    new Category { categoryName = "Сопливые"}, //4
                    new Category { categoryName = "Пафосные войнушки"}, //5
                    new Category { categoryName = "Мультяшки"}, //6
                    new Category { categoryName = "Коварные фантазии ученых"}, //7
                    new Category { categoryName = "Параллельные вселенные"}, //8
                    new Category {categoryName = "Эзотерика"}, //9
                    new Category {categoryName = "Исторические"}, //10
                    new Category {categoryName = "Мифы, легенды, сказки"} //11
                };


            }
        }
    }
}
    