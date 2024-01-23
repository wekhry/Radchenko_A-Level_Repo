namespace AlgorithmsHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
            Console.WriteLine("Fibonacci of 5: " + fibonacci.CalculateFibonacci(5));

            Factorial factorial = new Factorial();
            Console.WriteLine("Factorial of 5: " + factorial.CalculateFactorial(5));

            BinarySearch binarySearch = new BinarySearch();
            int[] array = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            int target = 13;
            Console.WriteLine("Index of " + target + " in the array: " + binarySearch.Search(array, target));

            QuickSort quickSort = new QuickSort();
            int[] arrayToSort = { 3, 6, 8, 10, 1, 2, 1 };
            quickSort.Sort(arrayToSort, 0, arrayToSort.Length - 1);
            Console.WriteLine("Sorted array: " + string.Join(", ", arrayToSort));
        }
    }
}
