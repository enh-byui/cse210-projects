public abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalValue;

    public string GetGoalName()
    {
        return _goalName;
    }

    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }

    public string GetGoalDescription()
    {
        return _goalDescription;
    }

    public void SetGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }

    public int GetGoalValue()
    {
        return _goalValue;
    }

    public void SetGoalValue(int goalValue)
    {
        _goalValue = goalValue;
    }

    public abstract string GetGoal();

    public abstract string GetGoalToSave();

    public abstract void SetCompletedGoal();
}