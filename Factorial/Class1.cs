using System;

namespace Factorial
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            int i, fact = 1;
            int number = 5;//It is the number to calculate factorial    
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);






        }
    }
}
