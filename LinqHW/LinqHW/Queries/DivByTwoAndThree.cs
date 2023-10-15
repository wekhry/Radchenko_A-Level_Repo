using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHW.Queries
{
    internal class DivByTwoAndThree
    {
        public void DivByTwoAndThreeQuery()
        {
            int[] numbers = { 1, 2, 3, 100, -10, 22, 36, 893, 13, 104, 33, 1, 3, -10, 22, 22, 36, 13, 1, 2 };

            var divisibleBy2and3 = numbers.Where(num => num % 2 == 0 && num % 3 == 0);

            Console.WriteLine("Numbers divisible by 2 and 3: ");

            foreach (var number in divisibleBy2and3)
            {
                Console.WriteLine(number);
            }
        }    
    }
}
