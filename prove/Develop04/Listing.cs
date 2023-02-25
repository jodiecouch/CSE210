using System;

public class Listing : Game
{
    const string _name = "Listing";
    const string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    const int _gameTime = 2;
    private List<string> _promptList = new List<string>();
    private int _p = 0;
    public Listing(string name = _name, string description = _description) : base(name, description)
    {
        FillPromptList();
    }

    public void Play()
    {
        this.ShowStartMessage();
        int counter = 0;
        Spinner spinner = new Spinner(_gameTime);
        Timer timer = new Timer();

        Console.WriteLine("List as many responses as you canto the following prompt:");
        Console.WriteLine(GetPrompt());
        spinner.Spin();
        Console.WriteLine("Begin now.");
        timer.Start(this._duration);
        string response;
        do
        {
            Console.Write("> ");
            response = Console.ReadLine();
            counter++;

        } while (timer.HasTime());

        Console.WriteLine($"You listed {counter} responses.");
        this.ShowEndMessage();
    }

    private string GetPrompt()
    {
        //iterate through the list of items again and again. Returning the next item in the list each time.
        if (_p >= _promptList.Count)
        {
            //reset to first list item
            _p = 0;
        }
        string text = _promptList[_p];
        _p++;
        return text;
    }

    private void FillPromptList()
    {
        string prompt = "Who are people that you appreciate?";
        _promptList.Add(prompt);
        prompt = "What are personal strengths of yours?";
        _promptList.Add(prompt);
        prompt = "Who are people that you have helped this week?";
        _promptList.Add(prompt);
        prompt = "When have you felt the Holy Ghost this month?";
        _promptList.Add(prompt);
        prompt = "Who are some of your personal heroes?";
        _promptList.Add(prompt);
    }
}