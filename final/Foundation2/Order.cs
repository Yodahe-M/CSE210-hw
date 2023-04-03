using System;
public class Order
{
    public Customer _customer = new Customer();
    private int _shippingCost;
    //private Product _product = new Product();
    private List<Product> products = new List<Product>();

   
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public int GetShippingCost()
    {
        bool isInUsa = _customer.CheckAddress();

        if (isInUsa) 
        {
            return 5;
        }

        return 35;
    }

    public void SetShippingCost(int shippingCost)
    {
        _shippingCost = shippingCost;
    }
    public double TotalCost()
    {

        double total = 0;

        foreach (Product product in products)
        {
            total += product.GetTotalPrice();
        }

        return total + GetShippingCost();


    }

    public void PackingLabel()
    {
        foreach (Product product in products)
        {
            Console.WriteLine($"{product.GetProductName()}, ID {product.GetProductId()} ${product.GetTotalPrice()}");
        }

    }

    public string ShippingLabel()
    {
        return _customer.GetShippingLable();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }
}