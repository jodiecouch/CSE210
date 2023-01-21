using System;
using System.IO;
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
            e.Display();
        }
    }

    public void SaveJournal(string fileName)
    {
        using (StreamWriter fileOut = new StreamWriter(fileName))
        {
            foreach (Entry e in journal)
            {
                fileOut.WriteLine($"{e._date},{e._prompt},{e._response}");
            }

        }
    }

    public void Clear()
    {
        journal.Clear();
    }

    public int EntryCount()
    {
        return journal.Count;
    }

}