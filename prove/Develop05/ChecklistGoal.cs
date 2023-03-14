public class ChecklistGoal : Goal
{
    private string _checklistGoal;
    private string _goalType;
    
    public ChecklistGoal()
    {
        _goalType = "Checklist Goal";
    }

    public void SetChecklistGoal()
    {

        
        Console.Write($"What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int goalSelection = int.Parse(Console.ReadLine());

        string goal = $"[ ] {goalName}, {goalDescription}, {goalSelection}";
        _checklistGoal = goal;

    }

    public string GetChecklistGoal(){
        return _checklistGoal;
    }
}