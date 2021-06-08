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
    public class Helper
    {
        private IArtistService artistService;
        private IGenreService genreService;
        public Helper()
        {
            artistService = new ArtistService();
            genreService = new GenreService();
        }

        public List<SelectListItem> GetGenreDropDown()
        {
            List<SelectListItem> genreList = new List<SelectListItem>();
            IList<Genre> genres = genreService.GetGenres();
            foreach (var item in genres)
            {
                genreList.Add(
                    new SelectListItem()
                    {
                        Text = item.Name,
                        Value = item.ID.ToString(),
                        Selected = (item.Name == (genres[0].Name) ? true : false)
                    }
                );
            }

            return genreList;
        }

        public List<SelectListItem> GetArtistDropDown()
        {
            List<SelectListItem> artistList = new List<SelectListItem>();
            IList<Artist> artists = artistService.GetArtists();
            foreach (var item in artists)
            {
                artistList.Add(
                    new SelectListItem()
                    {
                        Text = item.Name,
                        Value = item.ID.ToString(),
                        Selected = (item.Name == (artists[0].Name) ? true : false)
                    }
                );
            }

            return artistList;
        }
    }
}