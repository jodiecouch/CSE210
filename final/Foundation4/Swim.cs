using System;

public class Swim : Activity
{
    private double _laps;

    public Swim(string date, double minutes, double laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        double distance = (_laps * 50) / 620;
        return distance;
    }


}