using System;

namespace Union_and_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            //For example, if the input arrays are:
            //arr1[] = { 7, 1, 5, 2, 3, 6 }
            //arr2[] = { 3, 8, 6, 20, 7 }
            //Then your program should print Union as { 1, 2, 3, 5, 6, 7, 8, 20}
            //and Intersection as { 3, 6, 7}.
            // Time Complexity O(n+m)

            int[] arr1 = { 7, 1, 5, 2, 3, 6 };
            int[] arr2 = { 3, 8, 6, 20, 7 };
            int m = arr1.Length;
            int n = arr2.Length;
            Console.WriteLine("Union of two arrays is ");
            printUnion(arr1, arr2, m, n);
            Console.WriteLine("");
            Console.WriteLine("Intersection of two arrays is ");
            printIntersection(arr1, arr2, m, n);

        }
        static void printUnion(int[] arr1, int[] arr2, int m, int n)
        {
            if (m > n)
            {
                int[] tempp = arr1;
                arr1 = arr2;
                arr2 = tempp;

                int temp = m;
                m = n;
                n = temp;
            }

            Array.Sort(arr1);
            for (int i = 0; i < m; i++)
                Console.Write(arr1[i] + " ");
            for (int i = 0; i < n; i++)
            {
                if (binarySearch(arr1, 0, m - 1, arr2[i]) == -1)
                    Console.Write(arr2[i] + " ");
            }
        }
        static void printIntersection(int[] arr1, int[] arr2, int m, int n)
        {
            if (m > n)
            {
                int[] tempp = arr1;
                arr1 = arr2;
                arr2 = tempp;

                int temp = m;
                m = n;
                n = temp;
            }
            Array.Sort(arr1);
            for (int i = 0; i < n; i++)
            {
                if (binarySearch(arr1, 0, m - 1, arr2[i]) != -1)
                    Console.Write(arr2[i] + " ");
            }
        } 
        static int binarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;
                if (arr[mid] == x)
                    return mid;

                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);
                return binarySearch(arr, mid + 1, r, x);
            }
            return -1;
        }


    }
}
