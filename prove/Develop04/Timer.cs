using System;

public class Timer
{
    private DateTime _startTimer;
    private DateTime _endTimer;

    public void Start(int seconds)
    {
        _startTimer = DateTime.Now;
        _endTimer = _startTimer.AddSeconds(seconds);
    }
    public bool HasTime()
    {
        if (DateTime.Now < _endTimer)
        {
            return true;
        }
        return false;
    }
}