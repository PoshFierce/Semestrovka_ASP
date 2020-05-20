using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using WebFilm.Data.Models;
using System.IO;

namespace WebFilm.Data
{
    public class DBobjects
    {
        public static StreamReader reader = new StreamReader(@"C:\Users\мвидео\source\repos\WebFilm\WebFilm\Data\Content_Films.txt");
        public static void MyInitial(AppDBContent content)
        { 
            if (!content.GS_categories.Any())
                content.GS_categories.AddRange(Categories_Content.Select(c => c.Value));

            if (!content.GS_films.Any())
                content.GS_films.AddRange(ReadFilms());

            content.SaveChanges();
        }

        public static IEnumerable<Film> ReadFilms()
        {
            for(int j = 0; j < 7; j++)
                yield return new Film
                {
                    nameFilm = reader.ReadLine(),
                    shortDesc = reader.ReadLine(),
                    longDesc = reader.ReadLine(),
                    img = reader.ReadLine(),
                    Category = Categories_Content[reader.ReadLine()]
                };
            reader.Close();
        }

        private static Dictionary<string, Category> Dict_Category;

        public static Dictionary<string, Category> Categories_Content
        {
            get
            {
                if (Dict_Category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Страшилки"}, //0
                        new Category { categoryName = "Посмеяться"}, //1
                        new Category { categoryName = "Смотерть с серьезным лицом, морально-тяжелые"}, //2
                        new Category { categoryName = "Есть над чем задуматься, психологические"}, //3
                        new Category { categoryName = "Пафосные войнушки"}, //5
                        new Category { categoryName = "Мультяшки"}, //6
                        new Category { categoryName = "Коварные фантазии ученых"}, //7
                        new Category { categoryName = "Сопливые"}, //4
                        new Category { categoryName = "Параллельные вселенные"}, //8
                        new Category {categoryName = "Эзотерика"}, //9
                        new Category {categoryName = "Исторические"}, //10
                        new Category {categoryName = "Мифы, легенды, сказки"} //11
                    };

                    Dict_Category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        Dict_Category.Add(el.categoryName, el);
                }

                return Dict_Category;
            }
        }
    }
}
