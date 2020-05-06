using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStation
{
    class Player : IVisitor
    {
        public void Play(IPlaylist playlist, int bitrate)
        {
            StationsCollection bitrates = new StationsCollection();
            if(bitrates.GetItems().Contains(bitrate))
            {
                foreach(Composition c in playlist.Playlist)
                {
                    Console.WriteLine(c.Author + " - " + c.Name + ", " + bitrate.ToString() + " kbit/s");
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
