using System;

namespace Math_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square Root : {0}", squareRoot(9));
            Console.WriteLine("Power : {0}", power(3,3));

            Fibonacci();





        }

        public static double squareRoot(double number)
        {
            double temp;

            double sr = number / 2;

            do
            {
                temp = sr;
                sr = (temp + (number / temp)) / 2;
            } while ((temp - sr) != 0);

            return sr;
        }




        public static void Fibonacci()
        {

            int count = 7, num1 = 0, num2 = 1;
            Console.WriteLine("Fibonacci Series of " + count + " numbers:");

            int i = 1;
            while (i <= count)
            {
                Console.WriteLine(num1 + " ");
                int sumOfPrevTwo = num1 + num2;
                num1 = num2;
                num2 = sumOfPrevTwo;
                i++;
            }
        }


        public static long power(int number, int pow)
        { 
            long result = number;
            for (int i = 1; i < pow; i++)
                result *= pow;

            return result;
        }



    }
}
