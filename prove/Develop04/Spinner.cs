using System;

public class Spinner
{
    private Timer timer = new Timer();
    private int _duration;

    public Spinner(int durationInSeconds)
    {
        _duration = durationInSeconds;
    }

    public void Spin()
    {
        int counter = 0;
        timer.Start(_duration);
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

        } while (timer.HasTime());
        Console.CursorVisible = true;

    }

}