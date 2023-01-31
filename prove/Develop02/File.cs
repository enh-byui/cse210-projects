using System.IO;

public class FileStorage
{


    public List<string> _tempJournalEntry = new List<string>();

    public void SaveFile()
    {
        if (_tempJournalEntry.Count == 0)
        {
            Console.WriteLine("No entries to save today");
        }
        else
        {
            DateTime currentTimeDate = DateTime.Now;
            string dateText = currentTimeDate.ToString("Mddyyyy");
            string fileName = dateText + ".txt";

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                // You can add text to the file with the WriteLine method
                foreach (string entries in _tempJournalEntry)
                {
                    outputFile.WriteLine(entries);
                }

                // You can use the $ and include variables just like with Console.WriteLine
                //string color = "Blue";
                //outputFile.WriteLine($"My favorite color is {color}");
            }

            Console.WriteLine($"Your file was save with the name {fileName}");
        }
        Console.WriteLine("");
    }

    public void LoadFile()
    {

        DateTime currentTimeDate = DateTime.Now;
            string dateText = currentTimeDate.ToString("Mddyyyy");
            string fileDateName = dateText + ".txt";

        Console.Write($"Enter your file name ({fileDateName})");

        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                _tempJournalEntry.Add(line);

            }
        }
        else
        {
            Console.WriteLine("File does not exists");
        }




    }
}