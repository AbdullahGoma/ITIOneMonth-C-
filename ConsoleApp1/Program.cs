using System;
using System.Collections;
using System.Collections.Generic;
//Delegate
namespace ConsoleApp1
{
   
    class Program
    {

        public delegate bool SortDel(int x, int y);
        public enum Gender
        {
            male, female
        }


        public class Human
        {
            public string Name;
            public Gender gender;
            // public readonly Gender gender;
            private int _age;
            public int Age
            {
                get
                {
                    return _age;
                }
                set
                {
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
            public Employee()
            {
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
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 6, 7, 8, 3, 4, 5 };
            BubleSortUsingDel(a, SortDesc);
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        } 
        public static void BubleSortUsingDel(int[] a,SortDel del)
        {
            for(int i = 0;i < a.Length - 1; i++)
            {
                for(int j = 0;j < a.Length -1 - i;j++)
                {
                    if (del(a[j] , a[j+1]))
                    {
                        swap(ref a[j], ref a[j+1]);
                    }
                }
            }
        }

        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static bool SortDesc(int x, int y)
        {
            return x < y;
        }

        public static bool SortAsc(int x, int y)
        {
            return x > y;
        }

    }
}

