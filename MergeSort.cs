using System;

namespace ConsoleApp1
{
    class Program
    { 
        static void merge(int[] arr, int l, int m, int r)
        {
            int i = l;
            int j = m + 1;
            int k = l;

            /* create temp array */
            int[] temp = new int[arr.Length];

            while (i <= m && j <= r)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                    k++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                    k++;
                }
            }
            /* Copy the remaining elements of first half, if there are any */
            while (i <= m)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }

            /* Copy the remaining elements of second half, if there are any */
            while (j <= r)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }

            /* Copy the temp array to original array */
            for (int p = l; p <= r; p++)
            {
                arr[p] = temp[p];
            }
        }

        static void mergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int mid = (l + r) / 2;

                /* recurcive mergesort first and second halves */
                mergeSort(arr, l, mid);
                mergeSort(arr, mid + 1, r);

                merge(arr, l, mid, r);
            }
        }

        static void Main(string[] args)
        {
            int[] myarray = { 5, 2, 11, 10, 9, 7, 8, 6 };

            Console.WriteLine("Before Sorting");
            Console.WriteLine("[{0}]", string.Join(", ", myarray));

            // mergesort(arr,left,right) called
            mergeSort(myarray, 0, (myarray.Length - 1));

            Console.WriteLine("After Sorting");
            Console.WriteLine("[{0}]", string.Join(", ", myarray));
        }
 
    }
}
