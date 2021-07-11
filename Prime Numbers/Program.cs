using System;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            int num = 0;
            //Empty String
            String primeNumbers = "";

            for (i = 1; i <= 100; i++)
            {
                int counter = 0;
                for (num = i; num >= 1; num--)
                {
                    if (i % num == 0)
                    {
                        counter = counter + 1;
                    }
                }
                if (counter == 2)
                {
                    //Appended the Prime number to the String
                    primeNumbers = primeNumbers + i + " ";
                }
            }
            Console.WriteLine("Prime numbers from 1 to 100 are : {0}", primeNumbers); 



        }
    }
}
