using System;

public class Reflecting : Game
{
    const string _name = "Reflection";
    const string _description = "This activity will help you reflect on times in your " +
    "life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
    const int _reflectTime = 2;
    private List<string> _promptList = new List<string>();
    private List<string> _questionList = new List<string>();
    private int _p = 0;
    private int _q = 0;

    public Reflecting(string name = _name, string description = _description) : base(name, description)
    {
        FillPromptList();
        FillQuestionList();
    }

    public void Play()
    {
        this.ShowStartMessage();
        string response;
        Spinner spinner = new Spinner(_reflectTime);
        Timer timer = new Timer();
        timer.Start(this._duration);
        do
        {
            Console.WriteLine(GetPrompt());
            Console.WriteLine("When you have something in mind, press enter to continue.");
            response = Console.ReadLine();

            for (int i = 0; i < _questionList.Count(); i++)
            {
                if (timer.HasTime())
                {
                    Console.WriteLine(GetQuestion());
                    spinner.Spin();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
        } while (timer.HasTime());

        this.ShowEndMessage();
    }

    private void FillPromptList()
    {
        string prompt = "Think of a time when you stood up for someone else.";
        _promptList.Add(prompt);

        prompt = "Think of a time when you did something really difficult.";
        _promptList.Add(prompt);

        prompt = "Think of a time when you helped someone in need.";
        _promptList.Add(prompt);

        prompt = "Think of a time when you did something truly selfless.";
        _promptList.Add(prompt);
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

    private void FillQuestionList()
    {
        string q = "Why was this experience meaningful to you?";
        _questionList.Add(q);

        q = "Have you ever done anything like this before?";
        _questionList.Add(q);

        q = "How did you get started?";
        _questionList.Add(q);

        q = "How did you feel when it was complete?";
        _questionList.Add(q);

        q = "What made this time different than other times when you were not as successful?";
        _questionList.Add(q);

        q = "What is your favorite thing about this experience?";
        _questionList.Add(q);

        q = "What could you learn from this experience that applies to other situations?";
        _questionList.Add(q);

        q = "What did you learn about yourself through this experience?";
        _questionList.Add(q);

        q = "How can you keep this experience in mind in the future?";
        _questionList.Add(q);
    }

    private string GetQuestion()
    {
        //iterate through the list of items again and again. Returning the next item in the list each time.
        if (_q >= _questionList.Count)
        {
            //reset to first list item
            _q = 0;
        }
        string text = _questionList[_q];
        _q++;
        return text;
    }
}