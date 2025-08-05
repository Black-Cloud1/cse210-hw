using System;

class Program
{
    static void Main(string[] args)
    {
        // Object
        Assignment assignment1 = new Assignment("Samuel Bannett", "Multiplication");
        assignment1.Getsummary();

        Console.WriteLine(assignment1.Getsummary());

        // Object
        MathAssignment mathAssignment = new MathAssignment("Robrto Rodriguez", "Fraction", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mathAssignment.Getsummary());
        Console.WriteLine(mathAssignment.GetHomeWorkList());

        // Object
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by");
        Console.WriteLine(writingAssignment.Getsummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

        
    }
}