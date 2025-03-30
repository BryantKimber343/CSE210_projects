public class Address
{
    private string _country;
    private string _city;
    private string _state;
    private string _streetAddress;

    public Address()
    {
        _country = "";
        _city = "";
        _state = "";
        _streetAddress = "";
    }

    public Address(string country, string city, string state, string streetAddress)
    {
        _country = country;
        _city = city;
        _state = state;
        _streetAddress = streetAddress;
    }

    public bool IsInAmerica()
    {
        return _country.ToLower() == "united states" || _country.ToLower() == "usa";
    }

    public string MakeString()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }
}