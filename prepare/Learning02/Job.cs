using System;

public class Job
{
    public string _title;
    public string _company;
    public string _startYear;
    public string _endYear;

    public void Display()
    {
        Console.WriteLine($"{_title} ({_company}) {_startYear}-{_endYear}");
    }
}