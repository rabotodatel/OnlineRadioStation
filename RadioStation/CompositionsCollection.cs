using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStation
{
    class CompositionsCollection
    {
        private List<Composition> _compositions = new List<Composition>();
        public void AddComposition(Composition composition)
        {
            _compositions.Add(composition);
        }
        public void RemoveComposition(int id)
        {
            foreach(Composition song in _compositions)
            {
                if(song.ID==id)
                {
                    _compositions.Remove(song);
                }
            }
        }
        public Composition GetById(int id)
        {
            foreach(Composition song in _compositions)
            {
                if(song.ID==id)
                {
                    return song;
                }
            }
            return null;
        }
    }
}
