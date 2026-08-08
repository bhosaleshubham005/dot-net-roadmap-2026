using System;

Student s = new Student();


s.DisplayCollege();
Student.ShowCollegeName();

class Student
{
    string Name = "Shubham";
    int Age = 20;
    string Course = "Computer Science";

public static void ShowCollegeName()
{
    Console.WriteLine("College: ABC College");
}
    public void DisplayCollege()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Course: " + Course);
        Console.WriteLine("College: ABC College");
    }

    public void DisplayStudent()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Course: " + Course);
    }
}


