using System;
using System.Linq;

namespace ConsoleApp1
{
    class CombineTwoArraysWithoutDuplicate
    {


        static void Main(string[] args)
        {
            int[] num1 = { 1, 2, 3, 4, 3, 55, 23, 2 };
            int[] num2 = { 55, 23, 45, 50, 80 };
            Console.WriteLine("Array 1 : [{0}]", String.Join(",", num1));
            Console.WriteLine("Array 2 : [{0}]", String.Join(",", num2));


            var all = num1.Union(num2).ToArray();
            Console.WriteLine("output 1 : [{0}]", String.Join(",", all));
            Console.WriteLine("output 2 : [{0}]", String.Join(",", combineTwoArraysWithoutDuplicate(num1, num2)));
        }


        static int[] combineTwoArraysWithoutDuplicate(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length + arr2.Length];
            int index = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[index] = arr1[i];
                index++;
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[index] = arr2[i];
                index++;
            }
            //sort
            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = i; j < arr3.Length; j++)
                {
                    if (arr3[i] > arr3[j])
                    {
                        int temp = arr3[i];
                        arr3[i] = arr3[j];
                        arr3[j] = temp;

                    }
                }
            }


            // remove Duplicate
            int[] tempArr = new int[arr3.Length];
            int tempIndex = 0;
            for (int i = 0; i < arr3.Length - 1; i++)
            {
                if (arr3[i] != arr3[i + 1])
                {
                    tempArr[tempIndex++] = arr3[i];
                }
            }
            tempArr[tempIndex++] = arr3[arr3.Length-1];


            int[] tempArr2 = new int[tempIndex];

            for (int i = 0; i < tempIndex; i++)
            {
                tempArr2[i] = tempArr[i];
            }



            return tempArr2;
        }





    }
}
