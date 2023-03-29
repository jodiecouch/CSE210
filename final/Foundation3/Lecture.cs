using System;
public class Lecture : Event
{
    private string _speaker;
    private int _seatLimit;

    public Lecture(string title, string description, string date, string time, string street, string city,
     string state, string country, string speaker, int seats) :
     base(title, description, date, time, street, city, state, country)
    {
        _speaker = speaker;
        _seatLimit = seats;
    }
    public override string FullDetails()
    {
        string msg = Standard();
        msg += $"\r\nSpeaker: {_speaker} Capacity:{_seatLimit}";
        return msg;
    }
}