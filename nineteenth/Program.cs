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
        
        public MyStack(int n) {
            IndexTop = 0;
            stk = new int [n];
        } 

        //indexer
        public int this[int index]
        {
            get { return stk[index]; }
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

        public static MyStack operator + (MyStack S1,MyStack S2)
        {
            int s3 = S1.stk.Length + S2.stk.Length;
            // int s3 = S1.IndexTop+ S2.IndexTop;
            MyStack total= new MyStack(s3);
            for(int i = 0; i < S1.IndexTop;i++) {
                int x = S1[i];
                total.puch(x);
            }
            for(int i = 0; i < S2.IndexTop;i++) {
                int x = S2[i];
                total.puch(x);
            }
            return total;
        }
        
    }
    class Program
    {
        static void Main(string[] args) 
        {
            int s1,s2,s3;

            Console.WriteLine("Enter Size of Stack 1: ");
            int.TryParse(Console.ReadLine(), out s1);
            MyStack S1 = new MyStack(s1);

            Console.WriteLine("Enter Size of Stack 2: ");
            int.TryParse(Console.ReadLine(), out s2);
            MyStack S2 = new MyStack(s2); 

            

            for(int i = 0; i < s1;i++) {
                Console.WriteLine("Enter " + i + "th element to S1: ");
                int x = Convert.ToInt32(Console.ReadLine());
                S1.puch(x);
            }

            for(int i = 0; i < s2;i++) {
                Console.WriteLine("Enter " + i + "th element to S2: ");
                int x = Convert.ToInt32(Console.ReadLine());
                S2.puch(x);
            }

            s3 = s1 + s2;
            MyStack S3 = S1 + S2;

            Console.WriteLine("Elements of S3: ");
            for(int i = 0; i < s3;i++) {
                int x = S3[i]; 
                // S3.pop(x);
                Console.WriteLine(x);
            }
            for(int i = s3; 0 <= i-1;i--) {
                Console.WriteLine(S3.pop());
            }
            
        }
    }
}

