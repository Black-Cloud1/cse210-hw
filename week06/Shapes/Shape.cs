public abstract class Shape
{
    // Member variables
    private string _color;

    // Constructor that will be called from this base class
    public Shape(string color)
    {
        _color = color;
    }

    // Getter
    public string GetColor()
    {
        return _color;
    }
    // Setter
    public void SetColor(string color)
    {
        _color = color;
    }
    // Abstract behavior that will be change in other classes

    public abstract double GetArea();


    
}