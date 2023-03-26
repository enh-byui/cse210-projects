public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> Comments = new List<Comment>();

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        Comments.Add(comment);
    }

    public int GetNumComments()
    {
        return Comments.Count;
    }

    public void Print()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Length: " + Length + " seconds");
        Console.WriteLine("Number of comments: " + GetNumComments());

        foreach (Comment comment in Comments)
        {
            Console.WriteLine("\t" + comment.Name + ": " + comment.Text);
        }

        Console.WriteLine();
    }

}