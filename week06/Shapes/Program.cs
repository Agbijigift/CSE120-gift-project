using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        circle.SetColor("Blue");
        circle.SetRadius(360);
        circle.SetNameOfShape("Circle");

        Recangle recangle = new Recangle();
        recangle.SetColor("Yellow");
        recangle.SetLenght(55);
        recangle.SetWidth(45);
        recangle.SetNameOfShape("Rectangle");

        Square square = new Square();
        square.SetColor("Red");
        square.SetSides(4);
        square.SetNameOfShape("Square");

        //ShapeInfo(circle);
        //ShapeInfo(recangle);
        //ShapeInfo(square);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(circle);
        shapes.Add(recangle);
        shapes.Add(square);
        foreach (Shape s in shapes)
        {
            double area = s.GetArea();
            string color = s.GetColor();
            string name = s.GetNameOfShape();
            Console.WriteLine($"Shape:{name}");
            Console.WriteLine($"Color:{color}");
            Console.WriteLine($"Area:{area}");
            Console.WriteLine();

              
            
        }
    }
    //public static void ShapeInfo( Shape shape)
    //{
       // double area = shape.GetArea();
        //Console.WriteLine($"Color:{shape.GetColor()}");
        //Console.WriteLine($"Area:{shape.GetArea()}");
    //}
}