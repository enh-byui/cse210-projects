using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int askNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (askNumber != 0) {
            Console.Write("Enter a number: ");
            askNumber = int.Parse(Console.ReadLine());
            

            if (askNumber != 0) {
                numbers.Add(askNumber);
            }
        }

        int sum = 0;

        foreach (int number in numbers) {
            sum += number;
        }

        float average = ((float)sum) / numbers.Count;

        int maxValue = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxValue)
            {
                maxValue = number;
            }
        }

        //double average = numbers.Average();
        //int sum = numbers.Sum();
        //int maxValue = numbers.Max();



        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The highest number is: {maxValue}");
        
    }
}