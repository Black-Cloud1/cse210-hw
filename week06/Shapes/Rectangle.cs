public class Rectangle : Shape // class tha will be inherited
{
    // Member variable's
    private double _length;
    private double _width;

    // Inherit's functionality from the base class
    public Rectangle(string color, double lenght, double width) : base(color)
    {
        _length = lenght;
        _width = width;
    }

    // Behavior
    public override double GetArea()
    {
        return _length * _width;
    }




}
