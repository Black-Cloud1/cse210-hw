using System.Text;

public class Order
{
    // Member variables objects
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(List<Product> product, Customer customer)
    {
        _products = product;
        _customer = customer;
    }

    // Behaviors (Methods)
    public float GetTotalCost()
    {
        float total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }//                                        true
        float shippingCost = _customer.LivesInUSA() ? 5 : 35;

        return total + shippingCost;
    }
    public string GetPackingLabel()
    {
        string result = "";

        foreach (Product product in _products)
        {
            result += product.GetName() + " - ID: " + product.GetProductId() + "\n";
        }
        return result;
    }
    public string GetShippingLabel()
    {
        return _customer.GetName() + "\n" + _customer.GetAddress().FormatAddress();
    }

}