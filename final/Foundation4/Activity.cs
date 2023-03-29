using System;

public abstract class Activity
{
    protected string _date;
    protected double _minutes;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();

}