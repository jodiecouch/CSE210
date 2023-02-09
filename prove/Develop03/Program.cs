using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        //bool play = true;
        Scripture script = new Scripture(); //default to John 3:16
        WordPlay wp = new WordPlay(script);
        Menu menu = new Menu();
        //menu.Display();
        //Scripture matt = new Scripture("Matthew", "5", "3-5");
        script.Display();
        do
        {
            //play = DisplayMenu();
            menu.Display();
            if (menu.Input() == "ENTER")
            {
                if (wp.WordsRemaining())
                {
                    //play the current scripture
                    Console.Clear();
                    script.Title();
                    wp.Show();
                }
                else
                {
                    Console.Clear();
                    script.Title();
                    Console.WriteLine("Scripture Finished");
                }

            }
            else if (menu.Input() == "A")
            {
                //play same scripture again
                Console.Clear();
                wp.StartOver();
                script.Display();
                //wp.Show();

            }
            else if (menu.Input() == "N")
            {
                //get a new scripture
                Console.Clear();
                script = GetNewScripture();
                script.Display();
                wp = new WordPlay(script);
                //wp.Show();
            }
        } while (menu.Play() != false);
    }
    static Scripture GetNewScripture()
    {
        Scripture matt = new Scripture("Matthew", "5", "3-5");
        return matt;
    }

    /*
    static bool DisplayMenu()
    {
        string input;
        Console.WriteLine("Press enter to play. Type 'quit' to end the game. Type 'new' to get a new scripture.");
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
    */
}