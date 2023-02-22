using System;

public class Game
{
    private string _activityName;
    private string _activityDescription;
    protected int _duration;

    public Game(string activity, string description, int duration)
    {
        _activityName = activity;
        _activityDescription = description;
        _duration = duration;
    }

    public void ShowStartMessage()
    {
        Console.WriteLine("Starting Message");
    }

    public void ShowEndMessage()
    {
        Console.WriteLine("Ending Message");
    }

}