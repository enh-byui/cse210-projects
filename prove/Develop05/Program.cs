using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Score score = new Score();
        Goal goal = new Goal();
        int currentScore = score.GetScore();

        while (true)
        {
            Console.WriteLine($"You have {currentScore} points.");
            Console.WriteLine("");

            Console.WriteLine("Menu Options:");

            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            int goalSelection = int.Parse(Console.ReadLine());
            Console.Clear();


            if (goalSelection == 1)
            {

                while (true)
                {
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.WriteLine("  0. Back to main menu");
                    Console.Write("Select a choice from the menu: ");
                    int goalTypeSelection = int.Parse(Console.ReadLine());

                    if (goalTypeSelection == 1)
                    {

                        SimpleGoal simpleGoal = new SimpleGoal();
                        simpleGoal.SetSimpleGoal();
                        string simple = simpleGoal.GetSimpleGoal();
                        goal.AddGoal(simple);

                    }
                    else if (goalTypeSelection == 2)
                    {


                    }
                    else if (goalTypeSelection == 3)
                    {

                    }
                    else if (goalTypeSelection == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid option");
                    }
                }
            }
            else if (goalSelection == 2)
            {
                List<string> goals = goal.GetGoals();
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i}: {goals[i]}");
                }


            }
            else if (goalSelection == 3)
            {

            }
            else if (goalSelection == 4)
            {

            }
            else if (goalSelection == 5)
            {

            }
            else if (goalSelection == 6)
            {
                break;
            }
            else
            {
                Console.WriteLine("That is not a valid option");
            }
        }
    }
}