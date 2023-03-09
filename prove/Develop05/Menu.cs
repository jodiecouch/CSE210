using System;

public class Menu
{
    private string _input;
    private bool _play;
    private string _main = "Menu Options:\n" +
    "1. Create New Goal\n" +
    "2. List Goals\n" +
    "3. Save Goals\n" +
    "4. Load Goals\n" +
    "5. Record Event\n" +
    "6. Quit\n" +
    "Select from the menu: ";


    private void MainMenu()
    {
        Console.WriteLine($"\n{_main}");
    }

    public bool Play()
    {
        return _play;
    }
    public string Input()
    {
        return _input;
    }

    public void DisplayMain()
    {
        bool isValid = false;
        ConsoleKeyInfo inputKey;
        do
        {
            MainMenu();
            inputKey = Console.ReadKey(true);
            _input = inputKey.KeyChar.ToString().ToUpper();

            if (_input == "6" | inputKey.Key == ConsoleKey.Escape)
            {
                isValid = true;
                _play = false;
            }
            else if (_input == "1" | _input == "2" | _input == "3" | _input == "4" | _input == "5")
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
