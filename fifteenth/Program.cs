using System;

// Inheretance --> is a
// Struct value type 
// Class refference type
//22

namespace ConsoleApp1
{
   
    public class MyStack 
    {
        int [] stk;
        int IndexTop;
        
        public MyStack() {
            IndexTop = 0;
            stk = new int [4];
        } 

        public void puch(int x) {
            if(IndexTop < stk.Length) {
                stk[IndexTop] = x;
                IndexTop++;
            } else {
                Console.WriteLine("Stack is full.");
            }
        }

        public int pop() {
            if(IndexTop > 0) {
                IndexTop--;
                return stk[IndexTop];
            } else {
                Console.WriteLine("Stack is empty.");
                return -1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args) 
        {
            MyStack myStack= new MyStack(); 
            myStack.puch(10);
            myStack.puch(20);
            myStack.puch(30);
            myStack.puch(40);
            myStack.puch(50);

            Console.WriteLine(myStack.pop());
            Console.WriteLine(myStack.pop());
            Console.WriteLine(myStack.pop());
            Console.WriteLine(myStack.pop());
            Console.WriteLine(myStack.pop());
        }
    }
}

