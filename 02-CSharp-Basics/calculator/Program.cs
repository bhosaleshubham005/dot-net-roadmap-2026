using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine("===== Calculator =====");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine()!);

            if (choice == 5)
            {
                Console.WriteLine("Thank you!");
                break;
            }
            else
            {
                if (choice >= 6 && choice <= 1)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }

            Console.Write("Enter First Number: ");
            double a = double.Parse(Console.ReadLine()!);

            Console.Write("Enter Second Number: ");
            double b = double.Parse(Console.ReadLine()!);

            if (choice == 1)
                Console.WriteLine($"Answer = {a + b}");
            else if (choice == 2)
                Console.WriteLine($"Answer = {a - b}");
            else if (choice == 3)
                Console.WriteLine($"Answer = {a * b}");
            else if (choice == 4)
                Console.WriteLine($"Answer = {a / b}");
            else
                Console.WriteLine("Invalid Choice");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        } while (true); //rpeat till user will exit 
    }
}