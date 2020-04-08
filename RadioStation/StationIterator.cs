using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStation
{
    class StationIterator:Iterator
    {
        private StationsCollection _collection;
        private int _position = -1;
        private bool _reverse = false;
        public StationIterator(StationsCollection collection, bool reverse = false)
        {
            this._collection = collection;
            this._reverse = reverse;
            if(reverse)
            {
                this._position = collection.GetItems().Count;
            }
        }
        public override object Current()
        {
            return this._collection.GetItems()[_position];
        }
        public override int Key()
        {
            return this._position;
        }
        public override bool MoveNext()
        {
            int updatedPosition = this._position + (this._reverse ? -1 : 1);
            if(updatedPosition>=0 && updatedPosition < this._collection.GetItems().Count)
            {
                this._position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void Reset()
        {
            this._position = this._reverse ? this._collection.GetItems().Count - 1 : 0;
        }
    }
}
