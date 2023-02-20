using System;

class Program
{
    static void Main(string[] args)
    {

        int featureSelection = 1;
        Console.Clear();

        while (featureSelection >= 1 && featureSelection < 4)
        {

            Console.WriteLine("Menu Options:");

            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            featureSelection = int.Parse(Console.ReadLine());
            
            
            if (featureSelection == 1)
            {

            }
            else if (featureSelection == 4)
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