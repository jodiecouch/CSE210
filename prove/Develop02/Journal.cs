using System;
public class Journal
{
    private List<Entry> journal = new List<Entry>();

    public void Add(Entry e)
    {
        journal.Add(e);
    }

    public void Display()
    {
        //for each
        foreach (Entry e in journal)
        {
            Console.WriteLine($"Date: {e._date} - Prompt: {e._prompt}");
            Console.WriteLine(e._response);
        }
    }

}