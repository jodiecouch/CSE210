using System;

public class Menu
{
    private string _input;
    private bool _play;
    private string _text = "Menu Options:\n1. Start breathing activity\n2. Start reflection activity\n3. Start listing activity\n4. Quit\nSelect a choice from the menu:";

    private void Prompt()
    {
        Console.WriteLine($"\n{_text}");
    }

    public bool Play()
    {
        return _play;
    }
    public string Input()
    {
        return _input;
    }

    public void Display()
    {
        bool isValid = false;
        ConsoleKeyInfo inputKey;
        do
        {
            Prompt();
            inputKey = Console.ReadKey(true);
            _input = inputKey.KeyChar.ToString().ToUpper();

            if (_input == "4" | inputKey.Key == ConsoleKey.Escape)
            {
                isValid = true;
                _play = false;
            }
            else if (_input == "1" | _input == "2" | _input == "3")
            {
                isValid = true;
                _play = true;
            }
            else
            {
                isValid = false;
                _play = false;
            }

        } while (isValid == false);

    }
}
