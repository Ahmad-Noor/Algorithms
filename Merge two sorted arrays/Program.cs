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
            int[] arr3 = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;

            // Traverse both array 
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                    arr3[k++] = arr1[i++];
                else
                    arr3[k++] = arr2[j++];
            }

            // Store remaining, elements of first array 
            while (i < arr1.Length)
                arr3[k++] = arr1[i++];

            // Store remaining elements, of second array 
            while (j < arr2.Length)
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
