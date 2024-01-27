using System;

namespace ConsoleApp1
{
    class Program
    {
        static void swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void Method(out int x) 
        {
            x = 100;
        }
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            swap(ref x,ref y);
            Console.WriteLine(x + "   " + y);

            int z;
            Method(out z);
            Console.WriteLine(z);
        }
    }
}
