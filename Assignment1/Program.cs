using System;
using Assignment1;

class Program
{
    static void Main(string[] args)
    {
        var student1 = Student.CreateStudent("1", StudentType.FullTime, "John", "Anderson");
        var student2 = Student.CreateStudent("2", StudentType.FullTime, "Karen", "Smith");
        var student3 = Student.CreateStudent("3", StudentType.PartTime, "Kevin", "Peters");

        Console.WriteLine("Assignment One:");
        Student.OutputStudent(student1);
        Student.OutputStudent(student2);
        Student.OutputStudent(student3);
    }
}