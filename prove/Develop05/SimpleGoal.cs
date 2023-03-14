public class SimpleGoal : Goal
{
    private string _simpleGoal;
    private string _goalType;

    public SimpleGoal()
    {
        _goalType = "Simple Goal";
    }

    public void SetSimpleGoal()
    {

        
        Console.Write($"What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int goalSelection = int.Parse(Console.ReadLine());

        string goal = $"[ ] {goalName}, {goalDescription}, {goalSelection}";
        _simpleGoal = goal;

    }

    public string GetSimpleGoal(){
        return _simpleGoal;
    }
}