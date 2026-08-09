using System;



Student student = new Student();

student.DisplayName();
student.DisplayCourse();


class Person
{
    public string Name = "Shubham";

    public void DisplayName()
    {
        Console.WriteLine("Name: " + Name);
    }
}

class Student : Person
{
    public string Course = "Full stcack development";

    public void DisplayCourse()
    {
        Console.WriteLine("Course: " + Course);
    }
}
