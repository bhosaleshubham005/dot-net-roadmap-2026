class Person
{
    public void Display()
    {
        Console.WriteLine("Person");
    }
}

class Student : Person
{
    public void Display()
    {
        Console.WriteLine("Student");
    }

    public void ShowParent()
    {
        base.Display();  //base keyword used
    }
}