using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHW.Queries
{
    internal class SumOfNums
    {
        public void SumOfNumsQuery()
        {
            int[] numbers = { 1, 2, 3,100, -10, 22, 36, 893, 13, 104, 33, 1, 3, -10, 22, 22, 36, 13, 1, 2 };

            var sumOfNumbers = numbers.Sum();
            Console.WriteLine($"\nThe sum of all numbers is: {sumOfNumbers}\n");
        }
    }
}
