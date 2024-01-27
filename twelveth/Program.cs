using System;

namespace ConsoleApp1
{
    class Program
    {
        public struct Employee
        {
            public int Id;
            public string Name;
            public int Salary;
        }
        enum DaysOfWeek
        {
            Sat,Sun,Mon,Tue,Wed,Thu,Fri
        }

        enum Gender
        {
            male,female
        }
        public struct Complex 
        {
            public float real;
            public float imaginary;
            public void Display() {
                Console.WriteLine("Real = " + real + " , Imaginary = " + imaginary);
            }
        }

        public struct Human
        {
            public float height;
            public float width;
            public Human() {
                height = 10;
                width = 10;
            }

            public Human(float height, float width) {
                this.height = height;
                this.width = width;
            }

            public void Display() {
                Console.WriteLine("height = " + height + " , width = " + width);
            }
        }
        
        static void Main(string[] args)
        {
            // Complex complex = new Complex();
            // complex.Display(); 
            // complex.real = 10;
            // complex.imaginary = 20;
            // complex.Display();

            // Human human = new Human();
            // human.Display();
            // float height = 182;
            // float width = 45;
            // Human human1 = new Human(height, width);
            // human1.Display();
            DaysOfWeek d1 = (DaysOfWeek)0;
            Console.WriteLine(d1 + 1);
        }
    }
}
