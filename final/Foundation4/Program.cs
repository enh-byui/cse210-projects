using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2023, 5, 3), 30, 3.0));
        activities.Add(new Running(new DateTime(2023, 8, 3), 30, 4.8));
        activities.Add(new Cycling(new DateTime(2023, 9, 4), 45, 20));
        activities.Add(new Swimming(new DateTime(2023, 10, 5), 60, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}