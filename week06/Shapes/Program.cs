using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Purple", 6);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Yellow", 8, 4);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Black", 7);
        shapes.Add(shape3);

        foreach (Shape sh in shapes)
        {
            string color = sh.GetColor();
            double area = sh.GetArea();
            Console.WriteLine($"The {color} figure has an area of {area}.");
        }
        
    }
}