using System;

Student s = new Student();

s.DisplayCollege();
s.DisplayStudent();

int age = s.GetAge();
string info = s.GetStudentInfo();

Console.WriteLine("Returned Age: " + age);
Console.WriteLine("Student Info: " + info);

Student.ShowCollegeName();


class Student
{
    string Name = "Shubham";
    int Age = 20;
    string Course = "Computer Science";

    // Non-static method
    public void DisplayCollege()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Course: " + Course);
        Console.WriteLine("College: ABC College");
    }

    // Non-static method
    public void DisplayStudent()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Course: " + Course);
    }

    // Method returning int
    public int GetAge()
    {
        return Age;
    }

    // Method returning string
    public string GetStudentInfo()
    {
        return Name + " - " + Course;
    }

    // Static method
    public static void ShowCollegeName()
    {
        Console.WriteLine("College: ABC College");
    }
}