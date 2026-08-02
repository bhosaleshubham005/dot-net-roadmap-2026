using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Employee Salary Calculator");

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine()!;

        Console.Write("Enter Basic Salary: ");
        double basicSalary = double.Parse(Console.ReadLine()!);

        double pf = basicSalary * 0.10;
        double hra = basicSalary * 0.20;
        double netSalary = basicSalary + hra - pf;

        Console.WriteLine();
        Console.WriteLine("************* Salary Slip *************");
        Console.WriteLine($"Employee Name : {name}");
        Console.WriteLine($"Basic Salary  : {basicSalary}");
        Console.WriteLine($"PF Deduction  : {pf}");
        Console.WriteLine($"HRA           : {hra}");
        Console.WriteLine($"Net Salary    : {netSalary}");
    }
}