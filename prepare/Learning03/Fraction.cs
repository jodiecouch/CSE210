using System;
using System.Text;

public class Fraction
{
    private int _numer;
    private int _denom;

    public Fraction()
    {
        _numer = 1;
        _denom = 1;
    }
    public Fraction(int top)
    {
        _numer = top;
        _denom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _numer = top;
        _denom = bottom;
    }

    public int GetNumerator()
    {
        return _numer;
    }
    public void SetNumerator(int top)
    {
        _numer = top;
    }
    public int GetDenominator()
    {
        return _denom;
    }
    public void SetDenominator(int bottom)
    {
        _denom = bottom;
    }
    public string GetFractionString()
    {
        /*var builder = new StringBuilder();
        builder.Append(_numer).ToString();
        builder.Append("/");
        builder.Append(_denom).ToString();
        return builder.ToString();
        */
        string output = $"{_numer}/{_denom}";
        return output;
    }
    public double GetDecimalValue()
    {
        return (Convert.ToDouble(_numer) / Convert.ToDouble(_denom));
        //solution uses
        //return (double)_top / (double)_bottom;
    }
}