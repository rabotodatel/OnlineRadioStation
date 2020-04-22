using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStation
{
    class StationsCollection:IteratorAggregate
    {
        static List<int> _bitrates;
        bool _direction = false;
        public StationsCollection()
        {
            _bitrates = new List<int> { 64, 92, 128, 196, 224 };
        }
        public void ReverseDirection()
        {
            _direction = !_direction;
        }
        public List<int> GetItems()
        {
            return _bitrates;
        }
        public override IEnumerator GetEnumerator()
        {
            return new StationIterator(this, _direction);
        }
    }
}
