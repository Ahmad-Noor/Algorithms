using System;
using System.Linq;

namespace Merge_two_sorted_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //http://collabedit.com/
            int[] num1 = { -1, 0, 0, 10, 15, 20, 25, 30 };
            int[] num2 = { 0, 1, 1, 2, 8, 9, 20 };

            // output {-1,0,1,2,8,9,10,15,20,25,30}

            Console.WriteLine("output [{0}]", String.Join(",", MergeArrays(num1, num2)));

            Console.WriteLine("# Run Time Complexity : n" );
            Console.WriteLine("# Run Time space: n");

        }

        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int n1 = arr1.Length, n2 = arr2.Length;
            int[] arr3 = new int[n1 + n2];

            int i = 0, j = 0, k = 0;

            // Traverse both array 
            while (i < n1 && j < n2)
            {
                if (arr1[i] < arr2[j])
                    arr3[k++] = arr1[i++];
                else
                    arr3[k++] = arr2[j++];
            }

            // Store remaining, elements of first array 
            while (i < n1)
                arr3[k++] = arr1[i++];

            // Store remaining elements, of second array 
            while (j < n2)
                arr3[k++] = arr2[j++];

            // remove dublicati 
            int[] temp = new int[k];
            j = 0;

            for (i = 0; i < k - 1; i++)
                if (arr3[i] != arr3[i + 1])
                    temp[j++] = arr3[i];

            temp[j] = arr3[k - 1];

            arr3 = new int[j];
            Array.Copy(temp, arr3, j);

            return arr3;
        }


    }
}
