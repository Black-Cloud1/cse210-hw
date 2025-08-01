public class Customer
{
    // Private member variables
    private string _nameID;
    private Address _adress;

    // Constructor
    public Customer(string nameId, Address adress)
    {
        _nameID = nameId;
        _adress = adress;
    }
    // Behaviors (Methods)
    public string GetName()
    {
        return _nameID;
    }
    public Address GetAddress()
    {
        return _adress;
    }
    public bool LivesInUSA()
    {
        return _adress.LivesInUSA();
    }
}