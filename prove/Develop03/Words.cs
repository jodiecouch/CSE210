using System;
using System.Collections;


public class WordPlay
{
    private Scripture _script;
    private List<int> _hidden = new List<int>();
    private string[] _words;
    private Random _random = new Random();

    public WordPlay(Scripture s)
    {
        _script = s;
        _words = s.Text().Split(' ');
    }

    public void Show()
    {
        string showMe = "";
        if (WordHidden())
        {
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

    private bool WordHidden()
    {
        bool wordAdded = false;
        do
        {
            //randomize one more word
            int rNum = _random.Next(0, _words.Length);
            if (!_hidden.Contains(rNum))
            {
                _hidden.Add(rNum);
                wordAdded = true;
            }

        } while (wordAdded == false && WordsRemaining());

        return wordAdded;
    }


    public bool WordsRemaining()
    {
        if (_hidden.Count < _words.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void StartOver()
    {
        _hidden.Clear();
    }

}