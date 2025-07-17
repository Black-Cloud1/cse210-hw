using System;

class Program
{
    static void Main(string[] args)
    {
        // instances to call the constructors
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        // Display the diffrent representations
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDesimalValue());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDesimalValue());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDesimalValue());
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDesimalValue());

    }
}