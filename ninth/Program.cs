using System;

namespace ConsoleApp1
{
    class Program
    {
        // static void swap(int x, int y)
        // {
        //     int temp = x;
        //     x = y;
        //     y = temp;
        // }
        static void Method(int x, int y, int z) 
        {
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
            Console.WriteLine("Z = " + z);
        }
        static void Main(string[] args)
        {
            // int x = 10;
            // int y = 20;
            // swap(x, y);
            // Console.WriteLine(x + "   " + y);
            int l = 10;
            Method(l++, l++, l++);
        }
    }
}
