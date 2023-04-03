using System;

public class Customer
{
    private string _name;
    private Address _address = new Address();

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAddress(Address addr)
    {
        _address = addr;
    }

    public string GetName()
    {
        return _name;
    }

    public bool CheckAddress()
    {
        return _address.CheckAddress();
    }

    public string GetShippingLable()
    {
        return $"\n{_name} \n{_address.ReturnAddress()}";
    }
}