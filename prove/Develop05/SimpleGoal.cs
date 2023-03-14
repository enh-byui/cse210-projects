public class SimpleGoal : Goal
{
    protected string _goalStatus;
    public SimpleGoal()
    {
        _goalStatus = "False";
    }

    public void SetGoalStatus(string status)
    {
        _goalStatus = status;
    }
    public override string GetGoal()
    {
        string goalName = GetGoalName();
        string goalDescription = GetGoalDescription();
        int goalValue = GetGoalValue();

        string goalText = $"[ ] {goalName} ({goalDescription})";

        if(_goalStatus == "True")
        {
            goalText = $"[X] {goalName} ({goalDescription})";
            _goalValue = 0;
        }

        return goalText;
    }

    public override string GetGoalToSave()
    {
        string goalName = GetGoalName();
        string goalDescription = GetGoalDescription();
        int goalValue = GetGoalValue();
        return $"SimpleGoal:{goalName}:{goalDescription}:{goalValue}:{_goalStatus}";
    }

    public override void SetCompletedGoal()
    {
        _goalStatus = "True";
    }
}