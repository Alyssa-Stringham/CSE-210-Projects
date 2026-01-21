using System.Diagnostics.CodeAnalysis;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int wholeNumber)
    {
        _denominator = 1;
        _numerator = wholeNumber;
    }

    public Fraction(int numerator, int denominator)
    {
        _denominator = denominator;
        _numerator = numerator;
    }

    public int GetTop()
    {
        return _numerator;
    }
 
    public int GetBottom()
    {
        return _denominator;
    }

    public void SetTop(int numerator)
    {
        _numerator = numerator;
    }

    public void SetBottom(int denominator)
    {
        _denominator = denominator;
    }

    public string GetFractionString()
    {
        string text = $"{_numerator}/{_denominator}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_numerator/ (double) _denominator;
    }
}