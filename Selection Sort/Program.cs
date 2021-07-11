using System;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int array_size = 10;
            int[] array ={ 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            Console.WriteLine("The Array Before Selection Sort is: {0} ", String.Join(",", array));

            int tmp;
            for (int i = 0; i < array_size - 1; i++)
            {
                for (int j = i + 1; j < array_size; j++)
                {
                    if (array[i] > array[j])
                    {
                        tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            Console.WriteLine("The Array After Selection Sort is:  {0} ", String.Join(",", array));

        }

    }
}
