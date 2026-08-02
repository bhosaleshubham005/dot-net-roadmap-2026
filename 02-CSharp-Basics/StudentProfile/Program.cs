using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=================================");
        Console.WriteLine("       Student Profile");
        Console.WriteLine("=================================");

        Console.Write("Enter Name: ");
        string name = Console.ReadLine()!;

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine()!);

        Console.Write("Enter City: ");
        string city = Console.ReadLine()!;

        Console.Write("Enter Favourite Programming Language: ");
        string language = Console.ReadLine()!;

        Console.WriteLine();

        Console.WriteLine("profile created successfully!");
        Console.WriteLine($"Name      : {name}");
        Console.WriteLine($"Age       : {age}");
        Console.WriteLine($"City      : {city}");
        Console.WriteLine($"Language  : {language}");
        Console.WriteLine("");


    }
}