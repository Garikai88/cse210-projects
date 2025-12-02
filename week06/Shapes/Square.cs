using System;

public class Square : Shape
{
    private double _side;

    public Square(double side, string color ) : base(color)
    {
        _side = side;
    }

    // Override the GetArea method from the base class
    public override double GetArea()
    {
        return _side * _side; // The area of a square is side^2
    }

}