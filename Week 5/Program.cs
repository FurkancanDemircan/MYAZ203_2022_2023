using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_5
{
    public class Program
    {
        public static void Main()
        {
            /*
            var act01 = ResultSets.Action01();
            Console.WriteLine($"{act01.Status,-5}" +
                $"{act01.Message,5}");

            var act02 = ResultSets.Action02();
            Console.WriteLine($"{act02.Status,-5}" +
                $"{act02.Message,5}");

            var act03 = ResultSets.Action03();
            Console.WriteLine($"{act03.Status,-5}" +
                $"{act03.Message,5}");

            var act04 = ResultSets.Action04();
            Console.WriteLine($"{act04.Status,-5}" +
                $"{act04.Message,5}");*/

            MaxHeap heap = new MaxHeap();
            // MinHeap heap = new MinHeap();
            heap.Insert(5);
            heap.Insert(1);
            heap.Insert(3);
            heap.Insert(2);
            heap.Insert(4);

            Console.WriteLine($"{heap.Extract()}");
            Console.WriteLine($"{heap.Extract()}");
            Console.WriteLine($"{heap.Extract()}");
            Console.WriteLine($"{heap.Extract()}");
            Console.WriteLine($"{heap.Extract()}");
        }
    }
}
