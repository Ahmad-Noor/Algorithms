using System;

namespace _3_Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MergeSort ");

            int[] arr = { 12, 11, 13, 5, 6, 7 };

            //  int[] arr = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            Console.WriteLine("Input [{0}]", String.Join(",", arr));

            MergeSort(arr, 0, arr.Length - 1);
            Console.WriteLine("output [{0}]", String.Join(",", arr));

            Console.WriteLine("# Run Time Complexity : O(n log n)");
            Console.WriteLine("# Space Complexity : O(n)");
        }


        // Main function that  
        // sorts arr[l..r] using 
        // merge() 
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Find the middle  
                // point 
                int m = (left + right) / 2;

                // Sort first and  
                // second halves 
                MergeSort(arr, left, m);
                MergeSort(arr, m + 1, right);

                // Merge the sorted halves 
                merge(arr, left, m, right);
            }
        }



        // First subarray is arr[l..m] 
        // Second subarray is arr[m+1..r] 
        static void merge(int[] arr, int left, int m, int right)
        {
            // Find sizes of two  
            // subarrays to be merged 
            int n1 = m - left + 1;
            int n2 = right - m;

            // Create temp arrays 
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays 
            for (i = 0; i < n1; ++i) L[i] = arr[left + i];
            for (j = 0; j < n2; ++j) R[j] = arr[m + 1 + j];

            // Merge the temp arrays 

            // Initial indexes of first  
            // and second subarrays 
            i = 0;
            j = 0;

            // Initial index of merged  
            // subarry array 
            int k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements  
            // of L[] if any  
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements  
            // of R[] if any  
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
         

    }
}
