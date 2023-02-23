using System;

public class Game
{
    private string _activityName;
    private string _activityDescription;
    protected int _duration;
    const int _defaultTimer = 30;

    public Game(string activity, string description)
    {
        _activityName = activity;
        _activityDescription = description;
        _duration = _defaultTimer;
    }

    public void ShowStartMessage()
    {
        Console.WriteLine($"Activity: {_activityName}\nDescription: {_activityDescription}");
        Console.WriteLine("How many seconds would you like to play?");
        string timeString = Console.ReadLine();
        //Console.WriteLine($"Default duration is {_duration}");
        int inputTime;
        bool isNumeric = int.TryParse(timeString, out inputTime);
        if (isNumeric)
        {
            _duration = inputTime;
        }
        //Console.WriteLine($"New duration is {_duration}");
    }

    public void ShowEndMessage()
    {
        Console.WriteLine("Well done you!");
        Spinner spinner = new Spinner(2);
        spinner.Spin();
        Console.WriteLine($"You participated in {_activityName} for {_duration} seconds.");
        spinner.Spin();
        Console.Write("\b \b");
    }



}