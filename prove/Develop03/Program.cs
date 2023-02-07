using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        bool play = true;
        Scripture john = new Scripture();
        WordPlay wp = new WordPlay(john);
        //Scripture matt = new Scripture("Matthew", "5", "3-5");

        do
        {
            play = DisplayMenu();
            if (play)
            {

                john.Display();
                //matt.Display();
                Console.WriteLine("Next is word play");

                wp.Show();
            }
        } while (play != false);
    }

    static bool DisplayMenu()
    {
        string input;
        Console.WriteLine("Press enter to play or type 'quit' to end the game.");
        input = Console.ReadLine();
        if (input.ToUpper() == "QUIT")
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}