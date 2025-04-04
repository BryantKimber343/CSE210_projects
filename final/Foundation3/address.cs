/*
CLASS Address
Variables:
_country: string
_state: string
_city: string
_streetAdress: string
Methods:
Address(): void
Address(string country, string state, string city, string streetAddress)
GetAddress(): string
*/
public class Address
{
    private string _country;
    private string _state;
    private string _city;
    private string _streetAddress;

    public Address()
    {
        _country = "No country";
        _state = "No state";
        _city = "No city";
        _streetAddress = "No street address";
    }

    public Address(string country, string state, string city, string streetAddress)
    {
        _country = country;
        _state = state;
        _city = city;
        _streetAddress = streetAddress;
    }

    public string GetAddress()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }
}