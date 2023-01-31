public class PromptGenerator
{
    public int _promptNumber;
    public string _tempPrompt;


    public void QuestionPrompt(List<string> promptList)
    {
        var random = new Random();
        _promptNumber = random.Next(promptList.Count);
    }

    public void UniqueQuestion(List<string> promptList, int index)
    {
        Console.Write(promptList[index]);
        string promptAnswer = Console.ReadLine();
        _tempPrompt = promptList[index] + " " + promptAnswer;
    }

}