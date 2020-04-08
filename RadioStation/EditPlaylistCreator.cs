using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStation
{
    class EditPlaylistCreator : ICreator
    {
        public IEditPlaylist GetEditPlaylist()
        {
            return new EditPlaylist();
        }
    }
}
