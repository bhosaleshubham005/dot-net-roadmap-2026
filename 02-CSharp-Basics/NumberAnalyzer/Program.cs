using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine()!);

        int sum = 0;

        Console.WriteLine("\nNumbers:");
        for (int i = 1; i <= number; i++)
        {
            Console.Write(i + " ");
            sum += i;
        }

        Console.WriteLine("\n\nEven Numbers:");
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine("\n\nOdd Numbers:");
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine($"\n\nSum = {sum}");

    }
}