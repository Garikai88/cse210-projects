using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Test setters
        f1.SetTop(7);
        f1.SetBottom(2);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
    }
}

public class Fraction // This is the Fraction class to represent a mathematical fraction
{
    private int _top;  // These are the attributes for the top and bottom numbers and they are private
    private int _bottom;

    public Fraction()
    {
        _top = 1;  // Constructors that initialize the number to 1/1
        _bottom = 1;    // two parameters that are for the top and the bottom
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }


    // Setter for the top
    public void SetTop(int top)
    {
        _top = top;
    }


    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom != 0 ? bottom : 1;
    }

    // Setter for the bottom
    public void SetBottom(int bottom)
    {
        if (bottom != 0)
            _bottom = bottom;

        else
            Console.WriteLine("Denominator cannot be zero.");
    }

    public string GetFractionString()
    {
        return $"{_top} / {_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}

