using System;

public class Game
{
    private string _activityName;
    private string _activityDescription;
    protected int _duration;
    private const int _defaultTimer = 30;
    protected Timer timer = new Timer();

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

        int inputTime;
        bool isNumeric = int.TryParse(timeString, out inputTime);
        if (isNumeric)
        {
            _duration = inputTime;
        }

    }

    public void ShowEndMessage()
    {
        Console.WriteLine("Well done you!");
        Pause(2);
        Console.WriteLine($"You participated in {_activityName} for {_duration} seconds.");
        Pause(2);
        Console.Write("\b \b");
    }

    public void Pause(int pauseSeconds)
    {
        Timer pauser = new Timer();
        int counter = 0;
        pauser.Start(pauseSeconds);
        do
        {
            Console.CursorVisible = false;
            counter++;
            switch (counter % 4)
            //from stack overflow
            {
                case 0: Console.Write("/"); counter = 0; break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Thread.Sleep(600);
            // Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write("\b \b");

        } while (pauser.HasTime());
        Console.CursorVisible = true;

    }

}