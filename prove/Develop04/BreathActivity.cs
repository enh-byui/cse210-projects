public class BreathActivity : Activity
{
    private int _seconds;

    public BreathActivity(string activityName, string activityDescription) : base(activityName, activityDescription) {

    }

    public string StartActivity()
    {


          Console.WriteLine("Welcome to the Breathing Program!");


            Console.WriteLine("Press Enter to start.");

            // Wait for the user to press Enter
            Console.ReadLine();



            for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Sleep for 2 seconds.");
            Thread.Sleep(2000);
        }

        Console.WriteLine("Main thread exits.");



            while (true)
            {
                Console.WriteLine("Breathe in...");
                Thread.Sleep(4000);  // Wait for 4 seconds

                Console.WriteLine("Breathe out...");
                Thread.Sleep(4000);  // Wait for 4 seconds
            }
    }
}