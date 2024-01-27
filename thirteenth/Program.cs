using System;

namespace ConsoleApp1
{
    class Program
    {
        public struct Complex 
        {
            public float real;
            public float imaginary;
            
            public void Display() {
                Console.WriteLine("Real part = " + real + " , Imaginary part = " + imaginary);
                Console.WriteLine(real + " + " + imaginary + "i");
            }
            
        }

        static Complex add(Complex C1, Complex C2) {
                Complex Result;
                Result.real = C1.real + C2.real;
                Result.imaginary = C1.imaginary + C2.imaginary;
                return Result;
        }
        

        static void Main(string[] args)
        {
            Complex complex = new Complex();
            complex.real = 1;
            complex.imaginary = 1.5f;
            Complex complex1 = new Complex();
            complex1.real = 2;
            complex1.imaginary = 2.5f;
            Complex Result = add(complex, complex1);
            Result.Display();
        }
    }
}

