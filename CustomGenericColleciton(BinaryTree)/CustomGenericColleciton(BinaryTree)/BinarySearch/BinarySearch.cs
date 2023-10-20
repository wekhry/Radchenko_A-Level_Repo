using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericColleciton_BinaryTree_.BinarySearch
{
    public static class BinarySearch
    {
        public static int BinarySearchTree<T>(this T[] array, T value)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;
                int comparisonResult = Comparer<T>.Default.Compare(array[middle], value);

                if(comparisonResult == 0)
                {
                    return middle;
                }
                else if(comparisonResult < 0)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return -1;
        }
    }
}
