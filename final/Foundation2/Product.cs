using System;
public class Product
{
    private string _productName;
    private int _productId;
    private double _price;
    private int _quantity;



    public string GetProductName()
    {
        return _productName;
    }

    public void SetProductName(string productName)
    {
        _productName = productName;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public void SetProductId(int productId)
    {
        _productId = productId;
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(int price)
    {
        _price = price;
    }


    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
}