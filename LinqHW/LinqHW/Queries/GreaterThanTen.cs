using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHW.Queries
{
    internal class GreaterThanTen
    {
        public void GreaterThanTenQuery()
        {
            int[] numbers = { 1, 2, 3, 100, -10, 22, 36, 893, 13, 104, 33, 1, 3, -10, 22, 22, 36, 13, 1, 2 };

            var greaterThanTen = numbers.Where(num => num > 10);

            Console.WriteLine("\nNumbers greater than 10 and multiplied by 10:");
            foreach(var number in greaterThanTen)
            {
                Console.WriteLine(number*10);
            }
        }
    }
}
