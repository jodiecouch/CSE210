using System;
public class Event
{

    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, string street, string city, string state, string country)

    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = new Address(street, city, state, country);
    }

    public string Standard()
    {
        return $"{_title}\r\n{_description}\r\n{_date} {_time}\r\n{_address.GetAddress()}";
    }
    public string Short()
    {
        return $"{GetType()} - {_title} - {_date}";
    }
    public virtual string FullDetails()
    {
        string msg = Standard();
        return msg;
    }


}