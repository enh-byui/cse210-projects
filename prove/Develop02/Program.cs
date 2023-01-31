using System;

class Program
{


    static void Main(string[] args)
    {

        int featureSelection = 1;
        List<string> promptList = new List<string>(){
            "How was your day? ",
            "Who did you meet today? ",
            "what are you thankful for? "
        };

        List<string> tempJournalEntry = new List<string>();

        while (featureSelection >= 1 && featureSelection < 5)
        {
            Console.WriteLine("Welcome to your digital journal");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Please select an option: ");
            featureSelection = int.Parse(Console.ReadLine());

            Console.WriteLine($"");

            if (featureSelection == 1)
            {

                if (promptList.Count == 0)
                {
                    Console.WriteLine("No more questions to answer today");
                    Console.WriteLine("");
                }
                else
                {
                    PromptGenerator prompt = new PromptGenerator();

                    prompt.QuestionPrompt(promptList);
                    int index = prompt._promptNumber;

                    prompt.UniqueQuestion(promptList, index);
                    promptList.RemoveAt(index);
                    tempJournalEntry.Add(prompt._tempPrompt);

                    Console.WriteLine(tempJournalEntry.Count);

                    foreach (string entries in tempJournalEntry)
                    {
                        Console.WriteLine(entries);
                    }
                }
            }
            else if (featureSelection == 2)
            {
                //Console.WriteLine(tempJournalEntry.Count);
                Journal journal = new Journal();
                journal._tempJournalEntry = tempJournalEntry;
                journal.Display();
            }
            else if (featureSelection == 3)
            {
                FileStorage file = new FileStorage();
                file.LoadFile();
                tempJournalEntry = file._tempJournalEntry;
            }
            else if (featureSelection == 4)
            {
                FileStorage file = new FileStorage();
                file._tempJournalEntry = tempJournalEntry;
                file.SaveFile();
            }
            else if (featureSelection == 5)
            {
                Console.WriteLine("See you tomorrow!");
            }
            else
            {
                Console.WriteLine("That is not a valid option");
            }
        }






    }
}