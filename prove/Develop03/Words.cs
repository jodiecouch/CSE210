using System;
using System.Collections;


public class WordPlay
{
    private Scripture _script;
    private List<int> _hidden;
    private string[] _words;
    private Random _random;

    public WordPlay(Scripture s)
    {
        _script = s;
        _words = s.Text().Split(' ');
        _random = new Random();
        _hidden = new List<int>();
    }

    public void Show()
    {
        string showMe = "";

        //randomize one more word
        int rNum = _random.Next(0, _words.Length);
        _hidden.Add(rNum);

        foreach (int w in _hidden)
        {
            Console.WriteLine(w);
        }

        for (int i = 0; i < _words.Length; i++)
        {
            if (_hidden.Contains(i))
            {
                showMe = showMe + " __";
            }
            else
            {
                showMe = showMe + " " + _words[i];
            }

        }
        Console.WriteLine(showMe);
    }

}