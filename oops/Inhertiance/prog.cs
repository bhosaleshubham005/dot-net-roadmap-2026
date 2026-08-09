// using System;



// Student student = new Student();

// student.DisplayName();
// student.DisplayCourse();


// class Person
// {
//     public string Name = "Shubham";

//     public void DisplayName()
//     {
//         Console.WriteLine("Name: " + Name);
//     }
// }

// class Student : Person
// {
//     public string Course = "Full stcack development";

//     public void DisplayCourse()
//     {
//         Console.WriteLine("Course: " + Course);
//     }
// }




// // 


// Student student = new Student();
// Teacher teacher = new Teacher();

// student.DisplayStudent();
// teacher.DisplayTeacher();

// class Person
// {
//     public void DisplayPerson()
//     {
//         Console.WriteLine("Person");
//     }
// }

// class Student : Person
// {
//     public void DisplayStudent()
//     {
//         Console.WriteLine("Student");
//     }
// }

// class Teacher : Person
// {
//     public void DisplayTeacher()
//     {
//         Console.WriteLine("Teacher");
//     }
// }

// // base key word

// class Person
// {
//     public void Display()
//     {
//         Console.WriteLine("Person");
//     }
// }

// class Student : Person
// {
//     public void Display()
//     {
//         Console.WriteLine("Student");
//     }

//     public void ShowParent()
//     {
//         base.Display();  //base keyword used
//     }
// }


// hierarchical inheritance

using System;

Student student = new Student();
Teacher teacher = new Teacher();

student.DisplayStudent();
teacher.DisplayTeacher();

class Person
{
    public void DisplayPerson()
    {
        Console.WriteLine("Person");
    }
}

class Student : Person
{
    public void DisplayStudent()
    {
        Console.WriteLine("Student");
    }
}

class Teacher : Person
{
    public void DisplayTeacher()
    {
        Console.WriteLine("Teacher");
    }
}