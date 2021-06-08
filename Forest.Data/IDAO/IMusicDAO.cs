using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Forest.Data.Models.Domain;
using Forest.Data.Repository;

namespace Forest.Data.IDAO
{
    public interface IMusicDAO
    {
        Music GetMusic(int id, ForestContext context);

        void AddMusic(Music music, ForestContext context);
    }
}
