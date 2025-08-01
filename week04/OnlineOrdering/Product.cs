using System.Reflection.Metadata;

public class Product
{
    // Member variables
    private string _productName;
    private string _productId;
    private float _price;
    private int _quantity;

    // Constructors
    public Product(string productName, string productId, int price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }


    // Behaviors (Methods)
    public float GetTotalCost()
    {
        return _price * _quantity;
    }
    public string GetName()
    {
        return _productName;
    }
    public string GetProductId()
    {
        return _productId;
    }
}