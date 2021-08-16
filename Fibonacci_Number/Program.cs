using System;

namespace Fibonacci_Number
{
    class Program
    {

        static int Get_Fibonacci (int number)
        {
            int f0 = 0, f1 = 1;
	    
	    if(number==0) return f0;
	    if(number==1) return f1;

            for (int i = 2; i <= number; i++)
            {
                int savedF1 = f1;
                f1 = f1 + f0;
                f0 = savedF1;
            }
            return f1;
        }

	static void FindFibonacciNumberInRange(int n){
	   for(int i = 0 ; i < n ; i++){
		Console.WriteLine($"Fibonacci of item {i}");
	    }
	}

        static void Main(string[] args)
        {
           

           // int fibo = Get_Fibonacci(number);

           // Console.WriteLine(fibo);
	   do{
		
	    	Console.WriteLine("Input your number:");
            	int number = int.Parse(Console.ReadLine());
		if(number > 20) {
	             Console.WriteLine("You will get a large result @@");
		}
		FindFibonacciNumberInRange(number);
		
	   }while(number>20)
        }
    }
}
