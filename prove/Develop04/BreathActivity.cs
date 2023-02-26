public class BreathActivity : Activity
{

    public BreathActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {

    }

    public void StartActivity()
    {

        Console.WriteLine("");

        List<string> activityActions = new List<string>();
        activityActions.Add("Breathe in... ");
        activityActions.Add("Now breathe out... ");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = activityActions[i];
            Console.Write(s);
            for (int counter = 4; counter >= 1; counter--)
            {
                Console.Write(counter);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("");

            i++;

            if (i >= activityActions.Count)
            {
                i = 0;
                Console.WriteLine("");
            }
        }
        Console.WriteLine("Well Done!");
        Console.WriteLine("");
    }
}