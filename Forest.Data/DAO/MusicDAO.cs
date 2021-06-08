using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Forest.Data.IDAO;
using Forest.Data.Repository;
using Forest.Data.Models.Domain;

namespace Forest.Data.DAO
{
    public class MusicDAO : IMusicDAO
    {
        //private ForestContext context;
        //public MusicDAO()
        //{
        //    context = new ForestContext();
        //}
        public Music GetMusic(int id, ForestContext context)
        {
            Music music = context.Musics.Find(id);
            return music;
        }

        // add music to the database
        public void AddMusic(Music music, ForestContext context)
        {
            context.Musics.Add(music);
        }
    }
}
