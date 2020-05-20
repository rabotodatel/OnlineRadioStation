using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStationMiddleware
{
    class Facade
    {
        StationsCollection _bitrates;
        int _bitrate;
        IPlaylist _playlist;
        public Facade(IPlaylist playlist, int bitrate)
        {
            _bitrates = new StationsCollection();
            _playlist = playlist;
            _bitrate = bitrate;
        }
        public void Play()
        {
            if(_bitrates.GetItems().Contains(_bitrate))
            {
                foreach(Composition c in _playlist.Playlist)
                {
                    Console.WriteLine(c.Author + " - " + c.Name + ", " + _bitrate.ToString() + " kbit/s");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Error");
                Console.WriteLine("");
            }
        }
    }
}
