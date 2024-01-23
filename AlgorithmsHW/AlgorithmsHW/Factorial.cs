using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsHW
{
    internal class Factorial
    {
        public int CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * CalculateFactorial(n - 1);
        }
    }
}
