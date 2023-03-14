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
            Console.WriteLine("");
            Console.WriteLine($"You have {currentScore} points.");
            Console.WriteLine("");

            Console.WriteLine("Menu Options:");

            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Delete One Goal");
            Console.WriteLine("  7. Delete All Goals");
            Console.WriteLine("  8. Quit");
            Console.Write("Select a choice from the menu: ");
            int goalSelection = int.Parse(Console.ReadLine());
            Console.Clear();


            if (goalSelection == 1)
            {

                while (true)
                {
                    Console.WriteLine("");
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
                        Console.Write($"What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string goalDescription = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int goalValue = int.Parse(Console.ReadLine());
                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        int goalAttempts = int.Parse(Console.ReadLine());
                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        int goalBonus = int.Parse(Console.ReadLine());

                        ChecklistGoal checklistGoal = new ChecklistGoal();
                        checklistGoal.SetGoalName(goalName);
                        checklistGoal.SetGoalDescription(goalDescription);
                        checklistGoal.SetGoalValue(goalValue);
                        checklistGoal.SetGoalAttempts(goalAttempts);
                        checklistGoal.SetGoalBonus(goalBonus);


                        goals.Add(checklistGoal);

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
                int indexMenu = 0;

                foreach (Goal goal in goals)
                {
                    indexMenu++;

                    string goalText = goal.GetGoal();
                    Console.WriteLine($"{indexMenu}. {goalText}");
                }


            }
            else if (goalSelection == 3)
            {
                Console.Write($"What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                File.Create(fileName).Close();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    int finalScore = score.GetScore();
                    // You can add text to the file with the WriteLine method
                    outputFile.WriteLine($"{finalScore}");

                    foreach (Goal goal in goals)
                    {
                        string goalText = goal.GetGoalToSave();
                        outputFile.WriteLine($"{goalText}");
                    }
                }

            }
            else if (goalSelection == 4)
            {
                Console.Write($"What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(":");

                    string goalType = parts[0];

                    if (goalType == "SimpleGoal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal();
                        simpleGoal.SetGoalName(parts[1]);
                        simpleGoal.SetGoalDescription(parts[2]);
                        simpleGoal.SetGoalValue(int.Parse(parts[3]));
                        simpleGoal.SetGoalStatus(parts[4]);
                        goals.Add(simpleGoal);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal();
                        eternalGoal.SetGoalName(parts[1]);
                        eternalGoal.SetGoalDescription(parts[2]);
                        eternalGoal.SetGoalValue(int.Parse(parts[3]));
                        goals.Add(eternalGoal);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal();
                        checklistGoal.SetGoalName(parts[1]);
                        checklistGoal.SetGoalDescription(parts[2]);
                        checklistGoal.SetGoalValue(int.Parse(parts[3]));
                        checklistGoal.SetGoalAttempts(int.Parse(parts[4]));
                        checklistGoal.SetGoalBonus(int.Parse(parts[5]));
                        checklistGoal.SetGoalTries(int.Parse(parts[6]));
                        goals.Add(checklistGoal);
                    }
                    else
                    {
                        score.SetScore(int.Parse(parts[0]));
                        currentScore = score.GetScore();
                    }
                }
            }
            else if (goalSelection == 5)
            {

                Console.WriteLine("The goals are: ");
                int indexMenu = 0;

                foreach (Goal goal in goals)
                {
                    indexMenu++;

                    string goalText = goal.GetGoalName();
                    Console.WriteLine($"{indexMenu}. {goalText}");
                }
                Console.WriteLine("");

                Console.Write("Which goal did you accomplish? ");
                int goalSelected = int.Parse(Console.ReadLine());
                int goalIndex = goalSelected - 1;

                goals[goalIndex].SetCompletedGoal();

                int goalCurrentValue = goals[goalIndex].GetGoalValue();

                score.SetScore(goalCurrentValue);
                currentScore = score.GetScore();

            }
            else if (goalSelection == 6)
            {

                Console.WriteLine("The goals are: ");
                int indexMenu = 0;

                foreach (Goal goal in goals)
                {
                    indexMenu++;

                    string goalText = goal.GetGoalName();
                    Console.WriteLine($"{indexMenu}. {goalText}");
                }
                Console.WriteLine("");

                Console.Write("Which goal do you want to delete? ");
                int goalSelected = int.Parse(Console.ReadLine());
                int goalIndex = goalSelected - 1;

                goals.RemoveAt(goalIndex);

                Console.WriteLine("Your goal was successfully deleted");

            }
            else if (goalSelection == 7)
            {
                goals.Clear();

                Console.WriteLine("All goals successfully deleted");
            }
            else if (goalSelection == 8)
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