using System;

public class Prompts
{
    private string[] prompts = {
        "What horse(s) did you pet today?",
         "What dog(s) did you pet today?",
         "How did you treat your body like a temple today?",
        "What did you pray about today?",
        "What is something that you were grateful for today?"
    };

    public string Display(int num)
    {
        if ((num < prompts.Length) && (num >= 0))
        {
            return prompts[num];
        }
        else
        {
            return prompts[4];
        }

    }
    public int Max()
    {
        return prompts.Length;
    }
}