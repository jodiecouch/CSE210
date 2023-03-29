using System;
public class Reception : Event
{
    private string _email;
    public Reception(string title, string description, string date, string time, string street,
    string city, string state, string country, string email) :
    base(title, description, date, time, street, city, state, country)
    {
        _email = email;
    }
    public override string FullDetails()
    {
        string msg = Standard();
        msg += $"\r\nPlease RSVP at {_email}";
        return msg;
    }
}