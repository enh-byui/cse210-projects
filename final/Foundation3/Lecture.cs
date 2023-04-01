class Lecture : Event 
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string desctiption, string speaker, int capacity)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}