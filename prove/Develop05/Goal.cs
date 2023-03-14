public class Goal
{
    protected List<string> _goalList = new List<string>();
    private string _goal;
    public Goal()
    {

    }

    public void AddGoal(string goal)
    {
        _goalList.Add(goal);
    }

    public List<string> GetGoals(){
        return _goalList;
    }

    public void PromptQuestions(){
        Console.Write($"What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int goalSelection = int.Parse(Console.ReadLine());

        string goal = $"[ ] {goalName}, {goalDescription}, {goalSelection}";
        _goal = goal;
    }


}