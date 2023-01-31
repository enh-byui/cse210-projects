public class Journal
{

    public List<string> _tempJournalEntry = new List<string>();

    public void Display()
    {
        if (_tempJournalEntry.Count == 0)
        {
            Console.WriteLine("No entries for today");
        }
        else
        {
            foreach (string entries in _tempJournalEntry)
            {
                Console.WriteLine(entries);
            }
        }
        Console.WriteLine("");
    }

    
}