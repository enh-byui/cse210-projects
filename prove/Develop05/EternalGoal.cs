public class EternalGoal : Goal
{
    public override string GetGoal()
    {
        string goalName = GetGoalName();
        string goalDescription = GetGoalDescription();
        int goalValue = GetGoalValue();
        return $"[ ] {goalName} ({goalDescription})";
    }

    public override string GetGoalToSave()
    {
        string goalName = GetGoalName();
        string goalDescription = GetGoalDescription();
        int goalValue = GetGoalValue();
        return $"EternalGoal:{goalName}:{goalDescription}:{goalValue}";
    }

    public override void SetCompletedGoal()
    {

    }
}