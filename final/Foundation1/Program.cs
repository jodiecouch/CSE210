using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        Video v1 = new Video("Fried Green Tomatoes", "Southern Cookin", 300);
        v1.AddComment("Bobby Sue", "Just like MeeMaw used to make. I added a little more salt.");
        v1.AddComment("Laura Montgomery", "I like to salt my maters before I bread them. This is a good breading recipe.");
        v1.AddComment("Billy Joe McCallister", "I prefer mine with cornmeal in the breading. Good video on how to fry tomatoes or okra though.");

        Video v2 = new Video("Milk Biscuits", "Holly Smith", 265);
        v2.AddComment("Sara Johnson", "I have been looking for this recipe since our trip to Africa. Thank you.");
        v2.AddComment("Susan Schroeder", "We had to make two batches because we ate the first one before we could bake them. So good");
        v2.AddComment("Julius Orgibo", "I make these and then freeze the baked cookies. Put the frozen cookies in the kids lunches. They love them");
        v2.AddComment("Nancy Pitsaska", "Timely cookie recipe that requires no eggs. Thank you.");

        Video v3 = new Video("Cabbage Casserole", "Loretta Johns", 240);
        v3.AddComment("Wanda Jones", "This is a southern classic.");
        v3.AddComment("Jerry Kipinsky", "Gonna try this recipe with summer squash.");
        v3.AddComment("Sandra Summers", "Great potluck dish and great way to use up cabbage.");

        List<Video> videos = new List<Video>();
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video v in videos)
        {
            v.DisplayInfo();
            Console.WriteLine($"Number of Comments: {v.CommentCount()}");
            v.DisplayAllComments();
        }

    }
}