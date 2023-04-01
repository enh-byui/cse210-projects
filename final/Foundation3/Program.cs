using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Main St", "Anytown", "CA", "12345");
        Lecture lecture = new Lecture("Learning to run", "Some techniques to run", new DateTime(2023, 5, 10), "11:00 AM", address, "John Doe", 35);
        Address address2 = new Address("123 Long St", "Somewhere", "UT", "54321");
        Reception reception = new Reception("Our Welcome Party", "Come and join us to welcome everybody", new DateTime(2023, 7, 7), "07:00 PM", address2, "welcome@welcome.com");
        Address address3 = new Address("123 Short Av", "Anytown", "NY", "12123");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Dance", "Let's welcome summer dancing", new DateTime(2024, 7, 15), "05:00 PM", address3, "Sunny");

        Console.Clear();

        Console.WriteLine("===== Lecture Event =====");
        Console.WriteLine();
        Console.WriteLine("---- Standard Details -----");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("---- Full Details -----");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("---- Short Description -----");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("===== Reception Event =====");
        Console.WriteLine();
        Console.WriteLine("---- Standard Details -----");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("---- Full Details -----");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("---- Short Description -----");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("===== Outdoor Gathering Event =====");
        Console.WriteLine();
        Console.WriteLine("---- Standard Details -----");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine("---- Full Details -----");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine("---- Short Description -----");
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine();
    }
}