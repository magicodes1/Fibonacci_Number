using System;

namespace Fibonacci_Number
{
    class Program
    {

        static int Get_Fibonacci (int number)
        {
            int f0 = 0, f1 = 1;

            for (int i = 2; i <= number; i++)
            {
                int savedF1 = f1;
                f1 = f1 + f0;
                f0 = savedF1;
            }
            return f1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input your number:");
            int number = int.Parse(Console.ReadLine());

            int fibo = Get_Fibonacci(number);

            Console.WriteLine(fibo);        
        }
    }
}
