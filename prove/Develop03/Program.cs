using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        string featureSelection = "Continue";


        Reference reference = new Reference("Nefi", 2, 1, 3); // Nefi 2:1-3

        string learnScripture = reference.GetReference();

        Console.Clear();




        while (featureSelection != "quit")
        {
            Console.Clear();
            Console.WriteLine(learnScripture);
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            featureSelection = Console.ReadLine();
        }










    }
}