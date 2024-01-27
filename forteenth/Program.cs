using System;


//22

namespace ConsoleApp1
{

    public enum Gender
    {
        male,female
    }
    public struct Employee
    {
        public int Id;
        public string Name;
        public int Salary;
        public Gender G; 
        public string Genderity;
    }
    class Program
    {
        
        
        
        static void Main(string[] args)
        {
            Console.Clear();
            Employee[] employee = new Employee[3];

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
                Console.ResetColor();
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
                                AddEmployee(employee);
                                break;
                            case 1: //Display
                                Display(employee);
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
        static void AddEmployee(Employee[] employee) {
            for(int i = 0;i < 3;i++) {
                Console.WriteLine("Enter Your ID: ");
                int.TryParse(Console.ReadLine(), out employee[i].Id);
                Console.WriteLine("Enter Your Name: ");
                employee[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Your Salary: ");
                int.TryParse(Console.ReadLine(), out employee[i].Salary);
                Console.WriteLine("Enter Your Gender(M/F): ");
                employee[i].Genderity  = Console.ReadLine();
                
            }
        }

        static void Display(Employee[] employee) {
            for (int i = 0;i < 3;i++) {
                Console.WriteLine("ID for" + i + " th employee is equal to: " + employee[i].Id);
                Console.WriteLine("Name for" + i + " th employee is equal to: " + employee[i].Name);
                Console.WriteLine("Salary for" + i + " th employee is equal to: " + employee[i].Salary);
                switch (employee[i].Genderity) {
                    case "m":
                        Console.WriteLine("Genderity for" + i + " th employee is equal to: " + Gender.male);
                        break;
                    case "M":
                        Console.WriteLine("Genderity for" + i + " th employee is equal to: " + Gender.male);
                        break;
                    case "f":
                        Console.WriteLine("Genderity for" + i + " th employee is equal to: " + Gender.female);
                        break;
                    case "F":
                        Console.WriteLine("Genderity for" + i + " th employee is equal to: " + Gender.female);
                        break;

                }
            }
            Console.ReadLine();
        }
    }
}

