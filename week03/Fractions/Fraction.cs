using System;
using System.Dynamic;
public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public int get_topNumerator()
    {
        return _top;
    }
    public void set_topNumerator(int top)
    {
        _top = top;
    }
    public int get_bottomDenominator()
    {
        return _bottom;
    }
    public void set_bottomDenominator(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";

    }
    public double GetDesimalValue()
    {
        return (double)_top /(double) _bottom;
    }

}