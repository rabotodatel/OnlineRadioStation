using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStationMiddleware
{
    public class UserPlaylist : IPlaylist
    {
        public List<Composition> Playlist { get; } = new List<Composition>();
        //public void Accept(IVisitor visitor, int bitrate)
        //{
        //    visitor.Play(this, bitrate);
        //}
    }
}
