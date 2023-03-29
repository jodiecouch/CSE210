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
    public override double Speed()
    {
        double speed;
        if (_minutes != 0)
        {
            speed = (Distance() / _minutes) * 60;
        }
        else
        {
            speed = 0;
        }
        return speed;
    }
    public override double Pace()
    {
        double pace = 0;
        if (Distance() != 0)
        {
            pace = _minutes / Distance();
        }
        return pace;

    }

}