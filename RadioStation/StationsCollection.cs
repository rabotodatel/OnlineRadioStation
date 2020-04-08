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
        List<int> _bitrates = new List<int>();
        bool _direction = false;
        public void ReverseDirection()
        {
            _direction = !_direction;
        }
        public List<int> GetItems()
        {
            return _bitrates;
        }
        public void AddBitrate(int rate)
        {
            this._bitrates.Add(rate);
        }
        public override IEnumerator GetEnumerator()
        {
            return new StationIterator(this, _direction);
        }
    }
}
