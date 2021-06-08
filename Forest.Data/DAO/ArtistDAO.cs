using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Forest.Data.Models.Domain;
using Forest.Data.Repository;
using System.Data.Entity;
using Forest.Data.IDAO;

namespace Forest.Data.DAO 
{
    public class ArtistDAO : IArtistDAO
    {
        public IList<Artist> GetArtists(ForestContext context)
        {
            return context.Artists.ToList();
        }
        public Artist GetArtist(int id, ForestContext context)
        {
            // get article with provided id
            Artist artist = context.Artists.Find(id);
            return artist;
        }
        public void AddMusicToCollection(Music music, Artist artist, ForestContext context)
        {
            context.Artists.Find(artist.ID).Musics.Add(music);
        }
    }
}
