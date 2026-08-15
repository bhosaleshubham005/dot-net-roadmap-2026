using System ;

List<string> student = new List<string>();

student.Add("John");
student.Add("rohit");
student.Add("yash");
student.Add("sahil");

Console.WriteLine("Students:");

foreach (string s in student)
{
    Console.WriteLine(s);
}

Console.WriteLine("Total Students: " + student.Count);

student.Remove("rohit");
Console.WriteLine("After removing rohit:");
foreach (string s in student)
{
    Console.WriteLine(s);
}



// 
List<int> marks = new List<int>();

marks.Add(10);
marks.Add(12);
marks.Add(40);
marks.Add(50);

Console.WriteLine("Marks:");

foreach (int m in marks)
{
    Console.WriteLine(m);
}

Console.WriteLine("Total Marks: " + marks.Count);

marks.RemoveAt(1);

Console.WriteLine("After removing index 1:");

foreach (int m in marks)
{
    Console.WriteLine(m);
}