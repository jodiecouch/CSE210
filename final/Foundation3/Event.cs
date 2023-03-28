using System;
public class Event
{
    protected string _type;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event(string type, string title, string description, string date, string time, string address)

    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandard()
    {
        Console.WriteLine($"{_title}\r\n{_description}\r\n{_date} {_time}\r\n{_address}");
    }
    public void DisplayShort()
    {
        Console.WriteLine($"{_type} - {_title} - {_date}");
    }
    public void DisplayFull()
    {
        Console.WriteLine($"{_title}\r\n{_description}\r\n{_date} {_time}\r\n{_address}");
    }


}