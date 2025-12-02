using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        // Creating a list to hold shapoes
        List<Shape> shapes = new List<Shape>();

        // Adding a square, rectangle, and circle to the list
        shapes.Add(new Square(5, "Red"));       // side = 5
        shapes.Add(new Rectangle(4, 6,"Blue"));  // width = 4, height = 6
        shapes.Add(new Circle(3, "Green"));  // radius = 3

        // Iterate through the list and display color + area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }

}    

       