using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Score score = new Score();
        List<Goal> goals = new List<Goal>();

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
                        Console.Write($"What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string goalDescription = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int goalValue = int.Parse(Console.ReadLine());

                        SimpleGoal simpleGoal = new SimpleGoal();
                        simpleGoal.SetGoalName(goalName);
                        simpleGoal.SetGoalDescription(goalDescription);
                        simpleGoal.SetGoalValue(goalValue);
                        
                        goals.Add(simpleGoal);

                    }
                    else if (goalTypeSelection == 2)
                    {
                        Console.Write($"What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string goalDescription = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int goalValue = int.Parse(Console.ReadLine());

                        EternalGoal eternalGoal = new EternalGoal();
                        eternalGoal.SetGoalName(goalName);
                        eternalGoal.SetGoalDescription(goalDescription);
                        eternalGoal.SetGoalValue(goalValue);

                        goals.Add(eternalGoal);

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

                Console.WriteLine("The goals are:");

                foreach (Goal goal in goals){

                    string goalText = goal.GetGoal();
                    Console.WriteLine($"{goalText}");

                }


                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i]}");
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