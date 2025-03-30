public class Product
{
    private string _name;
    private double _price;
    private int _quantity;
    private int _id;

    public Product()
    {
        _name = "";
        _price = 0.0;
        _quantity = 0;
        _id = 0;
    }

    public Product(string name, double price, int quantity, int id)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
        _id = id;
    }

    public double GetTotalPrice()
    {
        return _price * _quantity;
    }

    public void Display()
    {
        Console.WriteLine($"Product Name: {_name}, Price: {_price}, Quantity: {_quantity}, ID: {_id}");
    }
}