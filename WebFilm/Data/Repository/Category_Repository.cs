using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFilm.Data.Interfaces;
using WebFilm.Data.Models;

namespace WebFilm.Data.Repository
{
    public class Category_Repository : IFilmsCategory
    {
        private readonly AppDBContent appDBContent;

        public Category_Repository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.GS_categories;
    }
}
