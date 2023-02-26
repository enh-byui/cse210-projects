class ReflectionActivity : Activity
{
    public ReflectionActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {

    }

    public void StartActivity()
    {
        List<string> promptSituations = new List<string>();
        promptSituations.Add("Think of a time when you felt truly proud of yourself.");
        promptSituations.Add("Think of a time when you faced a difficult challenge and overcame it.");
        promptSituations.Add("Think of a time when you felt grateful for someone's kindness.");
        promptSituations.Add("Think of a time when you had to make a tough decision and how you approached it.");
        promptSituations.Add("Think of a time when you had to step out of your comfort zone to achieve a goal.");
        promptSituations.Add("Think of a time when you received constructive feedback and how you responded to it.");
        promptSituations.Add("Think of a time when you felt like giving up, but persevered and achieved success.");
        promptSituations.Add("Think of a time when you helped someone in need and how it made you feel.");

        List<string> reflectQuestions = new List<string>();
        reflectQuestions.Add("Why was this experience meaningful to you?");
        reflectQuestions.Add("Have you ever done anything like this before?");
        reflectQuestions.Add("How did you get started?");
        reflectQuestions.Add("How did you feel when it was complete?");
        reflectQuestions.Add("What made this time different than other times when you were not as successful?");
        reflectQuestions.Add("What is your favorite thing about this experience?");
        reflectQuestions.Add("What could you learn from this experience that applies to other situations?");
        reflectQuestions.Add("What did you learn about yourself through this experience?");
        reflectQuestions.Add("How can you keep this experience in mind in the future?");

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");

        Random randomSituation = new Random();
        int situationIndex = randomSituation.Next(promptSituations.Count);
        Console.WriteLine($"--- {promptSituations[situationIndex]} ---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.Write("You may begin in: ");

        for (int counter = 5; counter >= 1; counter--)
        {
            Console.Write(counter);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Random randomSelectedQuestions = new Random();
        List<string> selectedQuestions = new List<string>();

        while (reflectQuestions.Count > 0)
        {
            int indexSelectedQuestions = randomSelectedQuestions.Next(reflectQuestions.Count);
            selectedQuestions.Add(reflectQuestions[indexSelectedQuestions]);
            reflectQuestions.RemoveAt(indexSelectedQuestions);

        }

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);


        foreach (string question in selectedQuestions)
        {
            if (DateTime.Now < endTime)
            {
                Console.Write(question);
                Spinner();
                Console.WriteLine("");
            }
            else
            {
                break;
            }
        }


        Console.WriteLine("Well Done!");
        Console.WriteLine("");
    }

}