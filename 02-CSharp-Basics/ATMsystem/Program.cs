using System;

class Program
{
    static void Main(string[] args)
    {
        int correctPin = 1234;
        double balance = 50000;

        Console.WriteLine("===== ATM Machine =====");

        Console.Write("Enter PIN: ");
        int pin = int.Parse(Console.ReadLine()!);

        if (pin == correctPin)
        {
            Console.Write("Enter Withdrawal Amount: ");
            double amount = double.Parse(Console.ReadLine()!);

            if (amount <= balance)
            {
                balance -= amount;

                Console.WriteLine();
                Console.WriteLine("Transaction Successful!");
                Console.WriteLine($"Remaining Balance : {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance.");
            }
        }
        else
        {
            Console.WriteLine("Invalid PIN.");
        }

        Console.ReadKey();
    }
}