public class ChecklistGoal : Goal
{
    private int _goalBonus;
    private int _goalAttempts;
    private int _goalTries;
    protected string _goalStatus;

    public ChecklistGoal()
    {
        _goalTries = 0;
    }

    public void SetGoalStatus(string status)
    {
        _goalStatus = status;
    }

    public void SetGoalAttempts(int goalAttempts)
    {
        _goalAttempts = goalAttempts;
    }

    public void SetGoalBonus(int goalBonus)
    {
        _goalBonus = goalBonus;
    }

    public void SetGoalTries(int goalTries)
    {
        _goalTries = goalTries;
    }

    public override string GetGoal()
    {
        string goalName = GetGoalName();
        string goalDescription = GetGoalDescription();
        int goalValue = GetGoalValue();
        string goalText = $"[ ] {goalName} ({goalDescription}) -- Currently completed: {_goalTries}/{_goalAttempts}";

        if (_goalAttempts == _goalTries)
        {
            goalText = $"[X] {goalName} ({goalDescription}) -- Currently completed: {_goalTries}/{_goalAttempts}";
        }

        return goalText;
    }

    public override string GetGoalToSave()
    {
        string goalName = GetGoalName();
        string goalDescription = GetGoalDescription();
        int goalValue = GetGoalValue();
        return $"ChecklistGoal:{goalName}:{goalDescription}:{goalValue}:{_goalAttempts}:{_goalBonus}:{_goalTries}";
    }

    public override void SetCompletedGoal()
    {
        _goalTries++;

        if (_goalTries == _goalAttempts)
        {
            int goalValueBonus = _goalValue + _goalBonus;
            SetGoalValue(goalValueBonus);
        }
        else if(_goalTries > _goalAttempts)
        {
            SetGoalValue(0);
            SetGoalTries(_goalAttempts);
        }
    }
}