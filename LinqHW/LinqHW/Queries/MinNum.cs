using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHW.Queries
{
    internal class MinNum
    {
        public void MinNumQuery()
        {
            int[] numbers = { 1, 2, 3, 100, -10, 22, 36, 893, 13, 104, 33, 1, 3, -10, 22, 22, 36, 13, 1, 2 };

            var minNum = numbers.Min();
            Console.WriteLine($"\nMin number in array is: {minNum}\n");
        }
    }
}
