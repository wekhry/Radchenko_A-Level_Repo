using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHW.Queries
{
    internal class GreaterThanAverage
    {
        public void GreaterThanAverageQuery()
        {
            int[] numbers = { 1, 2, 3, 100, -10, 22, 36, 893, 13, 104, 33, 1, 3, -10, 22, 22, 36, 13, 1, 2 };

            var average = numbers.Average();
            var greaterThanAverage = numbers.Where(num => num > average);
            Console.WriteLine("\nNumbers greater than average: ");
            foreach (var number in greaterThanAverage)
            {
                Console.WriteLine(number);
            }
        }
    }
}
