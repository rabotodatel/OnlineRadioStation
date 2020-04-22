using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStation
{
    class EditPlaylistAdvanced:IEditPlaylistAdvanced
    {
        private UserPlaylist _userPlaylist = new UserPlaylist();
        public EditPlaylistAdvanced(UserPlaylist userPlaylist)
        {
            _userPlaylist = userPlaylist;
        }
        public void AddCompositions(UserPlaylist userPlaylist)
        {
            _userPlaylist.Playlist.AddRange(userPlaylist.Playlist);
        }
    }
}
