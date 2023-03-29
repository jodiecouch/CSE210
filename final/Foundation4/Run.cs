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
    public override double Speed()
    {
        double speed;
        if (_minutes != 0)
        {
            speed = (_distance / _minutes) * 60;
        }
        else
        {
            speed = 0;
        }
        return speed;
    }
    public override double Pace()
    {
        double pace;
        if (_distance != 0)
        {
            pace = (_minutes / _distance) * 60;
        }
        else
        {
            pace = 0;
        }
        return pace;
    }

}