using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        Scripture script = library.GetScripture();

        WordPlay wp = new WordPlay(script);
        Menu menu = new Menu();

        script.Display();
        do
        {
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

            }
            else if (menu.Input() == "N")
            {
                //get a new scripture
                Console.Clear();
                script = library.GetScripture();
                script.Display();
                wp = new WordPlay(script);

            }
        } while (menu.Play() != false);
    }

}