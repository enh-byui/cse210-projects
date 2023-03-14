public class SimpleGoal : Goal
{
    private string _goal;

    public void SetGoal(string goal)
    {
        _goal = goal;
    }

    public override string GetGoal()
    {
        string goalName = GetGoalName();
        string goalDescription = GetGoalDescription();
        int goalValue = GetGoalValue();
        return $"[] {goalName} ({goalDescription})";
    }

}