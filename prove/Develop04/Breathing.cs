using System;

public class Breathing : Game
{
    const string _name = "Just Breathe";
    const string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    const string _breatheIn = "Breathe in ...";
    const string _breathOut = "Now breathe out ...";
    const int _breathingTime = 4;
    public Breathing(string name = _name, string description = _description) : base(name, description)
    { }

    public void Play()
    {
        this.ShowStartMessage();

        Spinner spinner = new Spinner(3);
        Console.WriteLine("Get ready ...\n");
        spinner.Spin();

        Timer timer = new Timer();
        timer.Start(this._duration);
        do
        {
            Console.Write(_breatheIn);
            Countdown();
            Console.Write("\b \b");
            Console.Write(".");
            Console.WriteLine();

            //CHECK TIME
            if (!timer.HasTime()) { break; }

            Console.Write(_breathOut);
            Countdown();
            Console.Write("\b \b");
            Console.Write(".");
            Console.WriteLine();
            Console.WriteLine();

        } while (timer.HasTime());

        this.ShowEndMessage();
    }

    private void Countdown()
    {
        Console.CursorVisible = false;
        for (int i = _breathingTime; i > 0; i--)
        {
            //sleep one second
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write($"{i}");
            Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
    }

}