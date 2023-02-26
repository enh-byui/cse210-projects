public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private string _activityDurationText;
    private int _activityDuration;

    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _activityDurationText = "How long, in seconds, would you like for your session?";
    }
    public string GetWelcomeMessage()
    {
        return $"Welcome to the {_activityName}.";
    }

    public string GetActivityDescription()
    {
        return $"{_activityDescription}";
    }

    public string GetActivityDurationText()
    {
        return $"{_activityDurationText}";
    }

    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    public string GetReadyMessage(){
        return "Get Ready...";
    }

    public void SetActivityDuration(int seconds)
    {
        _activityDuration = seconds;
    }

    public void Spinner()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(4);

        int i = 0;

        Console.WriteLine("");

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }

        }
    }




}