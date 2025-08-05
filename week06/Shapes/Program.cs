using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Blue", 5);
        Rectangle rectangle = new Rectangle("Green", 5, 10);
        Circle circle = new Circle("Circle", 5);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"The {s.GetColor()} shape has the area of {s.GetArea()}");
        }

    }
}