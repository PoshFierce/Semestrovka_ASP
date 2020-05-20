using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFilm.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebFilm.ViewModels;

namespace WebFilm.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFilmsCategory _allCategories;
        private readonly IAllFilms _allFilms;

        public HomeController(IAllFilms iallfilms, IFilmsCategory ifilmscategories)
        {
            _allFilms = iallfilms;
            _allCategories = ifilmscategories;
        }
        public ViewResult Index()
        {
            var homeCategories = new HomeViewModel
            {
                AllCategoriesHVM = _allCategories.AllCategories
            };
            return View(homeCategories);
        }
    }
}
