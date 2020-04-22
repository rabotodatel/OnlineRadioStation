using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStation
{
    class UserPlaylistCreator:ICreator
    {
        public IPlaylist GetUserPlaylist()
        {
            return new UserPlaylist();
        }
    }
}
