using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "y";

        Console.WriteLine("Guess a number between 1 to 100");
        

        while (playAgain == "y") {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            //int magicNumber = -1;
            int guessNumber = -1;
            int counter = 1;
            Console.WriteLine(magicNumber);

            while (magicNumber != guessNumber) {

                //Console.Write("What is the magic number? ");
                //magicNumber = int.Parse(Console.ReadLine());
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());

                if (magicNumber > guessNumber) {
                    Console.WriteLine("Higher");
                } else if (magicNumber < guessNumber) {
                    Console.WriteLine("Lower");
                } else {
                    Console.WriteLine("Great! you did it.");
                    Console.WriteLine($"It took {counter} times to guess the number.");

                    Console.Write("Do you want to play again? (y/n) ");
                    playAgain = Console.ReadLine();
                }

                counter += 1;
            }

            if (playAgain == "n") {
                Console.WriteLine($"Thank you, Good bye!");
            }
        }
    }
}