public class Goal
{
    protected List<string> _goalList = new List<string>();
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
        return "What is the name of your goal?";
    }

    



}