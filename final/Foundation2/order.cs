public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order()
    {
        _customer = new Customer();
        _products = new List<Product>();
    }

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0.0;
        foreach (Product product in _products)
        {
            total += product.GetTotalPrice();
        }
        if (_customer.IsInAmerica())
        {
            total += 5; // Flat shipping fee for American customers
        }
        else
        {
            total += 35; // Flat shipping fee for international customers
        }

        return total;
    }

    public void DisplayPackingLabel()
    {
        foreach (Product product in _products)
        {
            product.Display();
        }
    }
    public void DisplayShippingLabel()
    {
        _customer.Display();
    }
}