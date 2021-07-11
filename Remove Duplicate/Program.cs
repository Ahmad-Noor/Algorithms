using System;
using System.Collections;
using System.Collections.Generic;

namespace Remove_Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given a sorted array of integers. Remove the duplicates inplace without extra memory.
            int[] nums = { 1, 3, 3, 3, 5, 5, 7, 7, 7, 7 };
            int[] y = removeDuplicates(nums);

            Console.WriteLine(string.Format("[{0}]", string.Join(", ", y)));
        }
        public static int[] removeDuplicates(int[] nums)
        {
            int[] temp = new int[nums.Length];
            int tempIndex = 0;

            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] != nums[i+1])
                {
                    temp[tempIndex++] = nums[i];
                }
            }
            temp[tempIndex++] = nums[nums.Length-1];

            int[] temp2 = new int[tempIndex];
            Array.Copy(temp, temp2, tempIndex);
            return temp2;

        }


    }
}
