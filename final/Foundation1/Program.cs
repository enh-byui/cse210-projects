using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video { Title = "How to make a soup", Author = "Ramsey Cook", Length = 630 },
            new Video { Title = "How to paint my home", Author = "DFY", Length = 508 },
            new Video { Title = "Start running", Author = "Run for fun", Length = 250 }
        };

        videos[0].AddComment("Samantha", "Love this!");
        videos[0].AddComment("John", "Thank you for sharing!");
        videos[0].AddComment("Amy", "I'm gonna try");

        videos[1].AddComment("Peter", "Very useful");
        videos[1].AddComment("Kat", "It seem to be easy");
        videos[1].AddComment("Joshua", "Ready to start my own project");
        videos[1].AddComment("Normand", "Super easy with this tips");

        videos[3].AddComment("Mark", "These tips are really helpful, thanks!");
        videos[3].AddComment("Olivia", "I'm going to try out these exercises tomorrow!");
        videos[3].AddComment("Lucas", "Thanks for sharing your knowledge, Mike.");

        foreach (Video video in videos)
        {
            video.Print();
        }

        Console.ReadKey();
    }
}