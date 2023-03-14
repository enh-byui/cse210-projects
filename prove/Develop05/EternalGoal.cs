public class EternalGoal : Goal
{
    private string _goal;

    public void SetGoal(string goal)
    {
        _goal = goal;
    }

    public override string GetGoal()
    {
        return _goal;
    }
}