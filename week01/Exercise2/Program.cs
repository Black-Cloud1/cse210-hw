using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type in a numerical grade: ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string letter = "";
        string sign = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";

        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        int LastDigit = percent % 10;
        if (letter != "A" && letter != "F")
        {
            if (LastDigit >= 7)
            {
                sign = "+";
            }
            else if (LastDigit < 3)
            {
                sign = "-";
            }
        }

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("You did not pass this course.");
        }
            Console.WriteLine($"Your grade is {letter}{sign}");

    }
}