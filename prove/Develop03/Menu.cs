using System;

public class Menu
{
    private string _input;
    private bool _play;
    private string _text = "Press enter to play. \nType 'Q' or hit Esc to end the game." +
    Environment.NewLine +
    "Type 'N' to get a new scripture.\nType 'A' to play the same scripture again.";


    private void Prompt()
    {
        Console.WriteLine($"\n{_text}");
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

            if (inputKey.Key == ConsoleKey.Enter)
            {
                isValid = true;
                _play = true;
                _input = "ENTER";
            }
            else if (_input == "Q" | inputKey.Key == ConsoleKey.Escape)
            {
                isValid = true;
                _play = false;
            }
            else if (_input == "N")
            {
                isValid = true;
                _play = true;
            }
            else if (_input == "A")
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
    public bool Play()
    {
        return _play;
    }
    public string Input()
    {
        return _input;
    }

}