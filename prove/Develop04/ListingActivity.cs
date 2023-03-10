class ListingActivity : Activity
{
    public ListingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {

    }

    public void StartActivity()
    {
        List<string> promptSituations = new List<string>();
        promptSituations.Add("Who are people that you appreciate?");
        promptSituations.Add("What are personal strengths of yours?");
        promptSituations.Add("Who are people that you have helped this week?");
        promptSituations.Add("When have you felt the Holy Ghost this month?");
        promptSituations.Add("Who are some of your personal heroes?");

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine("");

        Random randomSituation = new Random();
        int situationIndex = randomSituation.Next(promptSituations.Count);
        Console.WriteLine($"--- {promptSituations[situationIndex]} ---");
        Console.WriteLine("");
        Console.WriteLine("You may begin in: ");

        List<string> responses = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);


        while (DateTime.Now < endTime)
        {

            Console.Write(">");
            string response = Console.ReadLine();
            responses.Add(response);

        }


        Console.WriteLine($"You have listed {responses.Count} items!");
        Console.WriteLine("Well Done!");
        Spinner();
        Console.WriteLine("");

    }
}