

using System;

namespace ConsoleApp1
{
    class Program
    {
        // static int id = 0;
        // static string name = "";
        // static int salary = 0;
        static void Main(string[] args)
        {
            int id = 0;
            string name = "";
            int salary = 0;
            Console.Clear();
            string[] Menu = 
            {
                "  New  ",
                "Display",
                "  Exit  "
            };

            int xDistance = Console.WindowWidth / 2;
            int yDistance = Console.WindowHeight / (Menu.Length + 1);
            bool flag = true;
            int highlight_index = 0;

            do{
                Console.Clear();
                for (int i = 0;i < Menu.Length;i++) {
                if(i == highlight_index) {
                    Console.BackgroundColor = ConsoleColor.Blue;
                } else {
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.SetCursorPosition(xDistance, (i + 1) * yDistance);
                Console.WriteLine(Menu[i]);
                }

                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key) {
                    case ConsoleKey.UpArrow:
                        highlight_index--;
                        if(highlight_index < 0) highlight_index = 2;
                        break;
                    case ConsoleKey.DownArrow:
                        highlight_index++;
                        if(highlight_index > 2) highlight_index = 0;
                        break;
                    case ConsoleKey.Home:
                        highlight_index = 0;
                        break;
                    case ConsoleKey.End:
                        highlight_index = 2;
                        break;
                    case ConsoleKey.Escape:
                        flag = false;
                        break;
                    case ConsoleKey.Enter:
                        switch(highlight_index)
                        {
                            case 0: //New
                                Employee(ref id,ref name,ref salary);
                                break;
                            case 1: //Display
                                Display(ref id,ref name,ref salary);
                                break;
                            case 2: //Exit
                                flag = false;
                                break;
                        }
                        break;
                }

            } while(flag);

        }

        //take id,name,salary and data for employee (function)
        static void Employee(ref int id,ref string name,ref int salary) {
            Console.WriteLine("Enter Your ID: ");
            int.TryParse(Console.ReadLine(), out id);
            Console.WriteLine("Enter Your Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your Salary: ");
            int.TryParse(Console.ReadLine(), out salary);
        }

        static void Display(ref int id,ref string name,ref int salary) {
            Console.WriteLine("Your ID is equal to: " + id);
            Console.WriteLine("Your name is equal to: " + name);
            Console.WriteLine("Your Salary is equal to: " + salary);
        }
    }
}

