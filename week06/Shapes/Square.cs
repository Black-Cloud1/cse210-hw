// public class that inherit's from the main class
public class Square : Shape
{
    // Member variable
    public double _side;

    // Constructor that will call from the base class
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Behavior (until you dont set the behavior the error wont disappear)
    public override double GetArea()
    {
        return _side * _side;
    }
}