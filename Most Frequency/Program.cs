using System;
using System.Collections.Generic;

namespace Most_Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 5, 2, 1, 3, 1, 1 };
            Console.WriteLine("Most Frequency: " + mostFrequency(arr1));
        }

        private static int mostFrequency(int[] arr)
        {
            Dictionary<int, int> dc = new Dictionary<int, int>();
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (dc.ContainsKey(arr[i]))
                {
                    dc[arr[i]] += 1;
                }
                else
                {
                    dc[arr[i]] = 1;
                }
                if (max < dc[arr[i]]) max = dc[arr[i]];

            }
            // Time Complexity O(n)
            return max;
        }
    }
}
