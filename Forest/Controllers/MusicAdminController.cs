using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Forest.Services.IService;
using Forest.Services.Models;
using Forest.Services.Service;

namespace Forest.Controllers
{
    public class MusicAdminController : Controller
    {
        private Helper helper;

        private IMusicService musicService;
        public MusicAdminController()
        {
            helper = new Helper();
            musicService = new MusicService();
        }
        // GET: MusicAdmin
        public ActionResult Index()
        {
            return View();
        }

        // GET: MusicAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MusicAdmin/Create
        public ActionResult AddMusic()
        {
            ViewBag.genreList = helper.GetGenreDropDown();
            ViewBag.artistList = helper.GetArtistDropDown();
            return View();
        }

        // POST: MusicAdmin/Create
        [HttpPost]
        public ActionResult AddMusic(MusicGenreArtist musicGenreArtist)
        {
            //try
            //{
                musicService.AddMusic(musicGenreArtist, "mo");
                return RedirectToAction("GetGenre", "Genre", new { id = musicGenreArtist.Genre});
            //}
            //catch
            //{
                //ViewBag.genreList = helper.GetGenreDropDown();
                //ViewBag.artistList = helper.GetArtistDropDown();
                //return View();
            //}
        }

        // GET: MusicAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MusicAdmin/Edit/5
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

        // GET: MusicAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MusicAdmin/Delete/5
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
