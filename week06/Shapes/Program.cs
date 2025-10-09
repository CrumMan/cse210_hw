using System;
using System.Drawing;
namespace shapes
{

    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();
            List<Shape> shapes = [];
            square.setColor("Blue");
            rectangle.setColor("Red");
            circle.setColor("Green");
            shapes.Add(circle);
            shapes.Add(square);
            shapes.Add(rectangle);
            foreach (Shape shape in shapes)
            {
                System.Console.WriteLine($"Shape \nColor: {shape.GetColor()} \nArea:{shape.GetArea()}\n");

            }
        }
    }
}