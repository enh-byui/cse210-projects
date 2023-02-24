using System;

class Program
{
    static void Main(string[] args)
    {

        int featureSelection = 1;
        int userSeconds = 0;
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

            Console.Write("+");

            Thread.Sleep(10000);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character


            Console.Write("Enter Seconds: ");
            userSeconds = int.Parse(Console.ReadLine());

//10

            for (int i = 0; i < userSeconds; i++)
            {

                Console.WriteLine("Breathe in...");
                Thread.Sleep(4000);  // Wait for 4 seconds

                Console.WriteLine("Breathe out...");
                Thread.Sleep(4000);  // Wait for 4 seconds

            }


            if (featureSelection == 1)
            {


            }
            else if (featureSelection == 4)
            {
                Console.WriteLine("See you tomorrow!");
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