public class Fraction
{
    private int numerator;
    private int denominator;

    // Constructor 1: No parameters 1/1
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor 2: One parameter, top only
    public Fraction(int top)
    {
        numerator = top;
        denominator = bottom != 0 ? bottom : 1;
    }

    // Getters, top
    public int GetTop()
    {
        return numerator;
    }

    //Getters, bottom
    public int GetBottom()
    {
        return denominator;
    }

    // Setters, top
    public void SetTop(int top)
    {
        numerator = top;
    }

    // Setters, bottom
    public void SetBottom(int bottom)
    {
        if (bottom != 0)
        {
            denominator = bottom;
        }
    }

    // Representation methods
    public string GetFractionString()
    {
        return $"{numerator} / {denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}

