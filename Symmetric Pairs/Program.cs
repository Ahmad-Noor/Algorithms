using System;
using System.Collections.Generic;

namespace Symmetric_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Given an array of pairs, find all symmetric pairs in it
            //Last Updated: 14 - 10 - 2019
            //Two pairs(a, b) and(c, d) are said to be symmetric if c is equal to b and a is equal to d.
            //For example, (10, 20) and(20, 10) are symmetric. Given an array of pairs find all symmetric pairs in it.
            //It may be assumed that the first elements of all pairs are distinct.

            //Example: 
            //Input: arr[] = { { 11, 20 }, { 30, 40 }, { 5, 10 }, { 40, 30 }, { 10, 5 } }
            //Output: Following pairs have symmetric pairs
            //        (30, 40)
            //        (5, 10)
            //We strongly recommend you to minimize your browser and try this yourself first.

            //A Simple Solution is to go through every pair, and check every other pair for symmetric.This solution requires O(n2) time.

            int[,] arr = new int[5, 2];
            arr[0, 0] = 11; arr[0, 1] = 20;
            arr[1, 0] = 30; arr[1, 1] = 40;
            arr[2, 0] = 5; arr[2, 1] = 10;
            arr[3, 0] = 40; arr[3, 1] = 30;
            arr[4, 0] = 10; arr[4, 1] = 5;
            findSymPairs(arr);
        }
        static void findSymPairs(int[,] arr)
        { 
            Dictionary<int, int> hM = new Dictionary<int, int>();
            int val = 0;
             
            for (int i = 0; i < arr.GetLength(0); i++)
            { 
                int first = arr[i, 0];
                int sec = arr[i, 1];
                 
                if (hM.ContainsKey(sec))
                    val = hM[sec]; 
                if (val != 0 && val == first)
                    Console.WriteLine("(" + sec + ", " + first + ")");

                else  
                    hM.Add(first, sec);
            }
        }
    }
}
