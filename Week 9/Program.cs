using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_9
{
    public class Program
    {
        public static void Main()
        {
            var collection = new List<int>()
            {
                1,2,3,4,5,6,7,8,9
            };

            IEnumerator<int> enums = collection.GetEnumerator();
            while (enums.MoveNext())
            {
                Console.WriteLine(enums.Current);
            }
        }
    }
}
