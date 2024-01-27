using System;

namespace ConsoleApp1
{
    class Program
    {
        // static void Method1() 
        // {
        //     Console.WriteLine("Method1");
        //     Method2();
        // }
        // static void Method2()
        // {
        //     Console.WriteLine("Methode2");
        // }

        // static int Pow(int number, int pow)
        // {
        //     if(pow == 0) return 1;
        //     return number * Pow(number, (pow - 1));
        // }

        static int factorial1(int number)
        {
            if(number <= 1) return 1;
            return number * factorial1(number - 1);
        }

        static int factorial2(int number)
        {
            int Result = 1;
            for(int i = number;i >= 1; i--) {
                Result *= i;
            }
            return Result;
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Method1();
            while(true) {
                int n;
                Console.WriteLine("Enter the number you want to calculate it's factorial.");
                int.TryParse(Console.ReadLine(), out n);
                int Result = factorial1(n);
                // int Result = factorial2(n);
                Console.WriteLine(Result);
            }
        }
    }
}
