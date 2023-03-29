using System;
public class Outdoor : Event
{
    private string _weather;
    public Outdoor(string title, string description, string date, string time, string street,
    string city, string state, string country, string weather) : base(title, description, date, time, street,
    city, state, country)
    {
        _weather = weather;
    }
    public override string FullDetails()
    {
        string msg = Standard();
        msg += $"\r\nExpected Weather: {_weather}";
        return msg;
    }
}