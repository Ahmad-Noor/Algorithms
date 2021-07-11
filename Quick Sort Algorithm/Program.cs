using System;

namespace Quick_Sort_Algorithm
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Quick Sort Algorithm ");
            int[] arr = { 10, 7, 8, 9, 1, 5 };

            Console.WriteLine("Input [{0}]", String.Join(",", arr));

            quickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("output [{0}]", String.Join(",", arr));

            Console.WriteLine("# Run Time Complexity : O(n log n)");
            Console.WriteLine("# Space Complexity : o(log n)");
        }
        static void quickSort(int[] arr, int left, int right)
        {
            if (right > left)
            {
                int pivot = arr[(left + right) / 2];
                int index = partition(arr, left, right, pivot);
                quickSort(arr, left, index - 1);
                quickSort(arr, index, right);
            }
        }
        static int partition(int[] arr, int left, int right, int pivot)
        {
            while (right >= left)
            {
                while (arr[left] < pivot) left++;
                while (arr[right] > pivot) right--;

                if (right >= left)
                {
                    swap(arr, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }
        private static void swap(int[] arr, int left, int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
    }

}
