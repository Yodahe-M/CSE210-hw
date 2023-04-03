using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;


    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }
    public bool CheckAddress()
    {
        if (_country == "USA")
        {
            return true;
        }
        return false;
    }

    public string ReturnAddress()
    {
        return $"Address: \n {_streetAddress} \n {_city} {_state} {_country}";
    }
}