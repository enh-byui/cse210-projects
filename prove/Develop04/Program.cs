using System;

class Program
{
    static void Main(string[] args)
    {

        int featureSelection = 1;
        int userSeconds = 0;
        Console.Clear();

        while (featureSelection >= 1 && featureSelection < 4)
        {

            Console.WriteLine("Menu Options:");

            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            featureSelection = int.Parse(Console.ReadLine());
            Console.Clear();


            if (featureSelection == 1)
            {
                BreathActivity breathe = new BreathActivity("Breath Activity", "This activity will help you relax by walking you through breating in and out slowly. Clear your mind and focus on your breathing.");
                string welcomeMessage = breathe.GetWelcomeMessage();
                string activityDescription = breathe.GetActivityDescription();
                string activityDurationText = breathe.GetActivityDurationText();
                string readyMessage = breathe.GetReadyMessage();
                string completedMessage = breathe.GetCompletedMessage();

                Console.WriteLine(welcomeMessage);
                Console.WriteLine("");
                Console.WriteLine(activityDescription);
                Console.WriteLine("");
                Console.Write(activityDurationText);

                userSeconds = int.Parse(Console.ReadLine());
                breathe.SetActivityDuration(userSeconds);
                Console.WriteLine($"Activity Duration {breathe.GetActivityDuration}");

                Console.Clear();
                Console.WriteLine(readyMessage);
                breathe.Spinner();

                breathe.StartActivity();
                Console.WriteLine(completedMessage);
                breathe.Spinner();
                Console.Clear();


            }
            else if (featureSelection == 4)
            {
                Console.WriteLine("See you tomorrow!");
            }
            else if (featureSelection == 4)
            {
                Console.WriteLine("See you tomorrow!");
            }
            else
            {
                Console.WriteLine("That is not a valid option");
            }

        }

    }
}