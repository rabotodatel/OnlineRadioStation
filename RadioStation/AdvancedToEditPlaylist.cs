using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStation
{
    class AdvancedToEditPlaylist:IEditPlaylist
    {
        private IEditPlaylistAdvanced _advanced;
        private UserPlaylist _playlist;
        public AdvancedToEditPlaylist(IEditPlaylistAdvanced advanced, UserPlaylist playlist)
        {
            _advanced = advanced;
            _playlist = playlist;
        }

        public void AddComposition()
        {
            _advanced.AddCompositions(_playlist);
        }

        public void RemoveComposition()
        {
            
        }
    }
}
