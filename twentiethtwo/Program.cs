﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public enum Gender
    {
        male,female
    }
    

    public class Human
    {
        public string Name;
        public Gender gender;
        // public readonly Gender gender;
        private int _age;
        public int Age 
        {
            get {
                return _age;
            }
            set {
                this._age = value;
            }
        }
        public virtual string ToString() 
        {
            return " Name: " + Name + " Age: " + Age + " Gender: " + gender;
        }

    }
    
    public class Employee : Human
    { 
        public int Id;
        public static int counter = 0;
        public int salary;
        public Employee() {
            counter++;
            Id = counter;
        } 
        public override string ToString() 
        {
            return "Id: " + Id + " Name: " + Name + " Age: " + Age + " Gender: " + gender + " Salary: " + salary;
        }
        public override bool Equals(object? obj)
        {
            return ((this.Id == (obj as Employee).Id) && (this.Name == (obj as Employee).Name) && (this.Age == (obj as Employee).Age) && (this.gender == (obj as Employee).gender) && (this.salary == (obj as Employee).salary));
        }
    }
    public static class ObjectEx
    {
        public static void AddObjects(this Employee[] employees, int n) {
            for(int i = 0; i < n; i++) {
                employees[i] = new Employee();
            }
        }
    }

    public class SortById : IComparer
    {
        public int Compare(object? x, object? y)
        {
            return (x as Employee).Id.CompareTo((y as Employee).Id);
        }
    }

    public class SortByIdDes : IComparer
    {
        public int Compare(object? x, object? y)
        {
            return -1 * (x as Employee).Id.CompareTo((y as Employee).Id);
        }
    }

    public class SortByName : IComparer
    {
        public int Compare(object? x, object? y)
        {
            return (x as Employee).Name.CompareTo((y as Employee).Name);
        }
    }
    public class SortBySalary : IComparer
    {
        public int Compare(object? x, object? y)
        {
            return (x as Employee).salary.CompareTo((y as Employee).salary);
        }
    }

    class Program
    {
        static void Main(string[] args) 
        {
            Console.Clear();
            int n;
            Console.WriteLine("Enter Number of Employees: ");
            int.TryParse(Console.ReadLine(), out n);
            Employee[] employee = new Employee[n];
            
            employee.AddObjects(n);

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
                                AddEmployee(employee, n);
                                break;
                            case 1: //Display
                                Display(employee, n);
                                break;
                            case 2: //Exit
                                flag = false;
                                break;
                        }
                        break;
                }

            } while(flag); 
        }


        static void AddEmployee(Employee[] employee, int n) {
            // Console.WriteLine("Enter Your ID: ");
            // int.TryParse(Console.ReadLine(), out Employee.Id);
            for(int i = 0;i < n;i++) {
                Console.WriteLine("Enter Your Name: ");
                employee[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Your Salary: ");
                int.TryParse(Console.ReadLine(), out employee[i].salary);
                Console.WriteLine("Enter Your Gender(M/F): ");
                string g  = Console.ReadLine(); 
                switch (g) {
                    case "m":
                        employee[i].gender = Gender.male;
                        break;
                    case "M":
                        employee[i].gender = Gender.male;
                        break;
                    case "f":
                        employee[i].gender = Gender.female;
                        break;
                    case "F":
                        employee[i].gender = Gender.female;
                        break;
                } 
                Console.WriteLine("Enter Your Age(18-60): ");
                employee[i].Age = Convert.ToInt32(Console.ReadLine());

            }
        }

        static void Display(Employee[] employee, int n)
        {
            Console.WriteLine("Choose What you Want From the next: ");
            Console.WriteLine("To Sort By Id press(1): ");
            Console.WriteLine("To Sort By Id Descending press(2): ");
            Console.WriteLine("To Sort By Salary press(3): ");
            Console.WriteLine("To Sort By Name press(4): ");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key) {
                case 1:
                    Array.Sort(employee, new SortById());
                    foreach (Employee emp in employee) {
                        Console.WriteLine(emp.ToString());
                    }
                    break;
                case 2:
                    Array.Sort(employee, new SortByIdDes());
                    foreach (Employee emp in employee) {
                        Console.WriteLine(emp.ToString());
                    }
                    break;
                case 3:
                    Array.Sort(employee, new SortBySalary());
                    foreach (Employee emp in employee) {
                        Console.WriteLine(emp.ToString());
                    }
                    break;
                case 4:
                    Array.Sort(employee, new SortByName());
                    foreach (Employee emp in employee) {
                        Console.WriteLine(emp.ToString());
                    }
                    break;
                // default:
                //     Console.WriteLine("Wrong Key!");
                //     break;
            }
            // for (int i = 0;i < n;i++) {
            //     Console.WriteLine("ID for " + i + "th employee is equal to: " + employee[i].Id);
            //     Console.WriteLine("Name for " + i + "th employee is equal to: " + employee[i].Name);
            //     Console.WriteLine("Salary for " + i + "th employee is equal to: " + employee[i].salary);
            //     Console.WriteLine("Gendarity for " + i + "th employee is equal to: " + employee[i].gender);
            //     Console.WriteLine("Age for " + i + "th employee is equal to: " + employee[i].Age);
            //     Console.WriteLine(employee[i].ToString());
            // }
            Console.ReadLine();
        }

    }
}
