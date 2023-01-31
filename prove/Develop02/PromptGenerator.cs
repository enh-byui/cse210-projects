public class PromptGenerator
{
    public int _promptNumber;
    public List<string> _tempPrompt = new List<string>();


    public void QuestionPrompt(List<string> promptList)
    {
        var random = new Random();
        _promptNumber = random.Next(promptList.Count);
    }

    public void UniqueQuestion(List<string> promptList, int index)
    {
        Console.Write(promptList[index]);
        string promptAnswer = Console.ReadLine();
        _tempPrompt.Add(promptList[index] + " " + promptAnswer);
    }
    
}