using System;

namespace Day07_Abstract
{
    public abstract class Shape
   {
     public string Color;

     public abstract double GetArea();
     public abstract double GetPerimeter();

     public void PrintAllDetails()
        {
            Console.WriteLine($"Color : {Color}");
            Console.WriteLine($"Area : {GetArea()}");
            Console.WriteLine($"Perimeter : {GetPerimeter()}");
        }

    }

     public class Circle : Shape
        {
            public double Radius;

        public Circle(string color, double radius)
        {
            this.Color  = color;
            this.Radius = radius;
        }
        public override double GetArea()
        {
            return 3.14 * Radius * Radius;
        }
        public override double GetPerimeter()
        {
        return 2 * 3.14 * Radius;
        }
        
        }
        

        public class Rectangle : Shape
    {
        public double Width;
        public double Height;
     public Rectangle(string color, double width, double height)
        {
            this.Color  = color;
            this.Width  = width;
            this.Height = height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
         return 2 * (Width + Height);
        }
    }

    public class Triangle : Shape
    {
   public double SideA;
        public double SideB;
        public double SideC;
        public double Height;
public Triangle(string color, double sideA, double sideB, double sideC, double height)
        {
            this.Color  = color;
            this.SideA  = sideA;
            this.SideB  = sideB;
            this.SideC  = sideC;
            this.Height = height;
        }
        public override double GetArea()
        {
            return 0.5 * SideA * Height;
        }

        public override double GetPerimeter()
        {
          return SideA + SideB + SideC; 
        }
    }

    public class ShapeTask
    {
        public static void Run()
        {
           // Circle
            Console.WriteLine("===== Circle =====");
            Circle circle = new Circle("Red", 5);
            circle.PrintAllDetails();

            // Rectangle
            Console.WriteLine("\n===== Rectangle =====");
            Rectangle rect = new Rectangle("Blue", 10, 5);
            rect.PrintAllDetails();

            // Triangle
            Console.WriteLine("\n===== Triangle =====");
            Triangle tri = new Triangle("Green", 6, 8, 10, 4);
            tri.PrintAllDetails();
        }
    }
    


}
