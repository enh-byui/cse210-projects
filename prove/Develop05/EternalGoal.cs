public class EternalGoal : Goal
{
    private string _eternalGoal;
    private string _goalType;

    public EternalGoal()
    {
        _goalType = "Eternal Goal";
    }

    public void SetEternalGoal()
    {

        
        Console.Write($"What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int goalSelection = int.Parse(Console.ReadLine());

        string goal = $"[ ] {goalName}, {goalDescription}, {goalSelection}";
        _eternalGoal = goal;

    }

    public string GetEternalGoal(){
        return _eternalGoal;
    }
}