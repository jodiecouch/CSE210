using System;
public class Scripture
{
    private string _book;
    private string _chapter;
    private string _verses;

    private string _text;

    /*
    public Scripture()
    {
        _book = "John";
        _chapter = "3";
        _verses = "16";
        _text = "text for John 3:16";
    }

    public Scripture(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verses = verse;
        _text = "text for this scripture";

    }
    */
    public Scripture(string book, string chapter, string verse, string text)
    {
        _book = book;
        _chapter = chapter;
        _verses = verse;
        _text = text;

    }
    public void Display()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verses}");
        Console.WriteLine($"{_text}");
    }
    public void Title()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verses}");
    }

    public string Text()
    {
        return _text;
    }
}