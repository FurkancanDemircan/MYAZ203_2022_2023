using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_5
{
    public abstract class Heap
    {
        protected SortedSet<int> _sortedSet;

        public Heap()
        {
            _sortedSet = new SortedSet<int>();
        }

        public void Insert(int item)
        {
            _sortedSet.Add(item);
        }

        public abstract int Extract();
    }
}
