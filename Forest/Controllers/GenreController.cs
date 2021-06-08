using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Forest.Data.Models.Domain;
using Forest.Services.IService;
using Forest.Services.Service;
namespace Forest.Controllers
{
    public class GenreController : Controller
    {
        IGenreService genreService;
        public GenreController()
        {
            genreService = new GenreService();
        }

        public ActionResult GetGenres()
        {
            return View(genreService.GetGenres());
        }

        // method to display musics collection
        // in a particular genre
        public ActionResult GetGenre(int id)
        {
            Genre genre = genreService.GetGenre(id);
            return View(genre);
        }

        // method to display the music
        // in the clicked genre
        public ActionResult GetMusics(int id)
        {
            Genre genre = genreService.GetGenre(id);
            IList<Music> musicsList = genre.Musics.ToList();

            return View(musicsList);
        }
        // GET: Genre
        public ActionResult Index()
        {
            return View();
        }

        // GET: Genre/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Genre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Genre/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Genre/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Genre/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Genre/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Genre/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
