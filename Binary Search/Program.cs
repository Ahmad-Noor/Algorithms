using System;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            Console.WriteLine("# Run Time Complexity : O(n log n)");
            Console.WriteLine("# Space Complexity : o(log n)");


        }

        // Using Recursion:

        public static object BinarySearchRecursive(int[] inputArray, int key, int min, int max)
        {
            if (min > max)
            {
                return "NaN"; // Not a Numbe
            }
            else
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    return BinarySearchRecursive(inputArray, key, min, mid - 1);
                }
                else
                {
                    return BinarySearchRecursive(inputArray, key, mid + 1, max);
                }
            }
        }
        // Binary Search without Recursion (Iterative):
        public static object BinarySearchIterative(int[] inputArray, int key, int min, int max)
        {
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return "NaN";// Not a Numbe
        }

    }
}
