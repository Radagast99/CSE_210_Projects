using System;

public class fraction
{
    private int _top = 0;
    private int _bottom = 0;

    public fraction() 
    {
        _top = 1;
        _bottom = 1;
    }

    public fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString() 
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}