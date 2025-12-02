using System;

public class Rectangle : Shape
{
    private double _width;
    private double _height;

    // Constructor: accepts color, width, and height
    public Rectangle(double width, double height, string color) : base(color)
    {
        _width = width;
        _height = height;
    }

    // Override GetArea
    public override double GetArea()
    {
        return _width * _height; // Area = width x height
    }
}