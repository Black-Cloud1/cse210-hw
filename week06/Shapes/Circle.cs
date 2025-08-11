public class Circle : Shape // class tha will be inherited
{
    // Member variables
    private double _radius;

    // Constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Behaviors
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }

}