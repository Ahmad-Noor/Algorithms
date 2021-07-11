using System;

namespace Integer_Reverse
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Reversed Number: " + ReversedNumber(1234));
        }
        static int ReversedNumber(int num)
        {
            int reversed = 0;
            while (num != 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }

            return reversed;
        }
    }
}
