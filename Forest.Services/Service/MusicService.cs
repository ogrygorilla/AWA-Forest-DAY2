using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Forest.Services.IService;
using Forest.Data.IDAO;
using Forest.Data.DAO;
using Forest.Data.Models.Domain;
using Forest.Data.Repository;
using Forest.Services.Models;

namespace Forest.Services.Service
{
    public class MusicService : IMusicService
    {
        private IMusicDAO musicDAO;
        private IGenreDAO genreDAO;
        private IArtistDAO artistDAO;
        private IUserDAO userDAO;
        public MusicService()
        {
            musicDAO = new MusicDAO();
            genreDAO = new GenreDAO();
            artistDAO = new ArtistDAO();
            userDAO = new UserDAO();
        }

        public Music GetMusic(int id)
        {
            using (var context = new ForestContext())
            {
                return musicDAO.GetMusic(id, context);
            }   
        }

        public void AddMusic(MusicGenreArtist musicGenreArtist, string userId)
        {
            #region - // Create the new music object
            Music newMusic = new Music()
            {
                Title = musicGenreArtist.Title,
                num_track = musicGenreArtist.num_track,
                duration = musicGenreArtist.duration,
                DateReleased = musicGenreArtist.DateReleased,
                Price = musicGenreArtist.Price,
                Image = musicGenreArtist.Image
            };
            #endregion
            #region - // Do work with DAO to add object and add to collections
            // create context object
            using (var context = new ForestContext())
            {
                // Add music
                musicDAO.AddMusic(newMusic, context); 
                // create genre object
                Genre genre = genreDAO.GetGenre(musicGenreArtist.Genre, context);
                // Add Music to collection of genre
                genreDAO.AddMusicToCollection(newMusic, genre, context);
                // create artist object
                Artist artist = artistDAO.GetArtist(musicGenreArtist.Artist, context);
                // Add Music to collection of artist
                artistDAO.AddMusicToCollection(newMusic, artist, context);
                // add music to collection of user
                userDAO.AddMusicToCollection(newMusic, userId, context);
                context.SaveChanges();
                // context object is disposed
            };
            #endregion
        }
    }
}
