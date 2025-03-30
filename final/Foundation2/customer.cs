public class Customer
{
    private string _name;
    private Address _address;
    public Customer()
    {
        _name = "";
        _address = new Address();
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInAmerica()
    {
        return _address.IsInAmerica();
    }

    public void Display()
    {
        Console.WriteLine($"Customer Name: {_name}, Address: {_address.MakeString()}");
    }
}