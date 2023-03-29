using System;

public class Activity
{
    protected string _date;
    protected double _minutes;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double Distance()
    {
        return 0;
    }
    public virtual double Speed()
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
    public virtual double Pace()
    {
        double pace = 0;
        if (Distance() != 0)
        {
            pace = _minutes / Distance();
        }
        return pace;
    }

    public string GetSummary()
    {
        string msg = $"{_date} {GetType()}({_minutes} min) - Distance {Math.Round(Distance(), 2)} miles, Speed {Math.Round(Speed(), 2)} mph, Pace {Math.Round(Pace(), 2)} min per mile";
        return msg;
    }

}