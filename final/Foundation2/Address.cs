using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _state = state;
        _city = city;
        _country = country;
    }

    public string GetAddress()
    {
        string address = $"{_street}\r\n{_city} {_state}, {_country}";
        return address;
    }

    public string GetCountry()
    {
        return _country;
    }
}