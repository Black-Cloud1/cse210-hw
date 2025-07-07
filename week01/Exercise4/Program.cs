using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Exercise4 Project.");
        Console.WriteLine("");


        List<int> numbers = new List<int>();
        int userNumbers = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumbers != 0)
        {
            Console.Write("Enter number: ");
            userNumbers = int.Parse(Console.ReadLine());

            if (userNumbers != 0)
            {
                numbers.Add(userNumbers);
            }

        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        float average = ((float)sum) / numbers.Count;

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers.");
        }

        Console.WriteLine($"The sum is:{sum}");
        Console.WriteLine($"The average is:{average}");
        Console.WriteLine($"The largest number is:{max}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        numbers.Sort();

        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}