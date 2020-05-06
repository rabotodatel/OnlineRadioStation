using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStation
{
    interface IVisitor
    {
        void Play(IPlaylist playlist, int bitrate);
    }
}
