using System;

//22

namespace ConsoleApp1
{
   
    public abstract class GeometricShape
    {
        protected int dim1;
        protected int dim2;

        public GeometricShape() 
        {
            dim1 = dim2 = 1;
        }
        public GeometricShape(int x) 
        {
            dim1 = dim2 = x;
        }
        public GeometricShape(int x, int y)
        {
            dim1 = x;
            dim2 = y;
        }

        public abstract float area();

    }

    public class Rectangle : GeometricShape
    {
        public int width{ 
            set
            {
                dim1 = value;
            }
            get
            { return dim1; }
         }
        public int Length
        { 
            set
            {
                dim2 = value;
            }
            get { return dim2; }
        }
        public Rectangle()
        {

        }
        public Rectangle(int x, int y) : base(x,y)
        {
        }

        public override float area()
        {
            return dim1 * dim2;
        }
    }

    public class Tritangle : GeometricShape
    {
        public int Base{ 
            set
            {
                dim1 = value;
            }
            get
            { return dim1; }
         }
        public int Height
        { 
            set
            {
                dim2 = value;
            }
            get { return dim2; }
        }
        public Tritangle()
        {

        }
        public Tritangle(int x, int y) : base(x,y)
        {
        }

        public override float area()
        {
            return 0.5f * Base * Height;
        }
    }

    public class Circle : GeometricShape
    {
        public int Radius
        { 
            set
            {
                dim1 = dim2 = value;
            }
            get { return dim1; }
        }
        public Circle()
        {

        }
        public Circle(int r) : base(r)
        {
        }

        public override float area()
        {
            return 3.14f * dim1 * dim2;
        }
    }




    class Program
    {
        static void Main(string[] args) 
        {
            Rectangle rectangle= new Rectangle(4, 5);
            Console.WriteLine("Area for Rectangle = " + rectangle.area());

            Tritangle tritangle = new Tritangle(3, 4);
            Console.WriteLine("Area for Triangle = " + tritangle.area());

            Circle circle = new Circle(4);
            Console.WriteLine("Area for Circle = " + circle.area());

            GeometricShape[] geometricShapes = new GeometricShape[] {rectangle, tritangle, circle};
            float Summition = 0;
            foreach (GeometricShape geometricShape in geometricShapes)
            {
                Summition += geometricShape.area();
            }
            Console.WriteLine("Summition for all = " + Summition);
            
        }
    }
}

