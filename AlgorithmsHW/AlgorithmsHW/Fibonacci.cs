using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsHW
{
    internal class Fibonacci
    {
        public int CalculateFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        }
    }
}
