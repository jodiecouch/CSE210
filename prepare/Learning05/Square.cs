using System;

public class Square : Shape
{
    private double _side;

    public Square(string color, double length) : base(color)
    {
        _side = length;
    }
    public override double GetArea()
    {
        return (_side * _side);
    }
}