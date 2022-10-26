using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_5
{
    public abstract class Heap
    {
        // {0,1,2,3,4,5}
        protected SortedSet<int> _heaps;

        public Heap()
        {
            _heaps = new SortedSet<int>();
        }
        
        public void Insert(int item)
        {
            _heaps.Add(item);
        }

        public abstract int Extract();
    }
}
