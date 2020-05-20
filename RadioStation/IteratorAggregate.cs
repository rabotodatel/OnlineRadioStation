using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStationMiddleware
{
    abstract class IteratorAggregate:IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
