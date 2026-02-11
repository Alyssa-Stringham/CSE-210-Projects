using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        SquareShape square = new SquareShape("Red", 5);
        //string squareColor = square.GetColor();
        //double squareArea = square.GetArea();
        //Console.WriteLine($"{squareColor}, {squareArea}");

        RectangleShape rectangle = new RectangleShape("Green", 4, 6);
        //string rectangleColor = rectangle.GetColor();
        //double rectangleArea = rectangle.GetArea();
        //Console.WriteLine($"{rectangleColor}, {rectangleArea}");        
        
        CircleShape circle = new CircleShape("Blue", 3);
        //string circleColor = circle.GetColor();
        //double circleArea = circle.GetArea();
        //Console.WriteLine($"{circleColor}, {circleArea}");        

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}