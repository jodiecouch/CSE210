using System;

public class Run : Activity
{
    private double _distance;

    public Run(string date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }


}