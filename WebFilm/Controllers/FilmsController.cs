using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFilm.Data.Interfaces;
using WebFilm.ViewModels;

namespace WebFilm.Controllers
{
    public class FilmsController : Controller
    {
        private readonly IAllFilms _allFilms;
        private readonly IFilmsCategory _allCategories;

        public FilmsController(IAllFilms iallfilms, IFilmsCategory ifilmscategories)
        {
            _allFilms = iallfilms;
            _allCategories = ifilmscategories;
        }

        public ViewResult filmsList()
        {
            ViewBag.Title = "Страница с фильмами";
            FilmsListViewModel obj = new FilmsListViewModel();
            obj.getAllFilms = _allFilms.GSFilms;
            obj.currCategory = "Фильмы curr";
            return View(obj);
        }
    }
}
