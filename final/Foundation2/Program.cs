using System;

class Program
{
    static void Main(string[] args)
    {
        

        Address address1 = new Address();
        address1.SetStreetAddress("675 s 4rd e");
        address1.SetCity("Rexburg");
        address1.SetState("ID");
        address1.SetCountry("USA");
        
        Customer customer1 = new Customer();
        customer1.SetAddress(address1);
        customer1.SetName("David Smith");





        Product product1 = new Product();
        product1.SetProductName("Milk");
        product1.SetProductId(4532);
        product1.SetPrice(9);
        product1.SetQuantity(2);

        
        // set everything

        Product product2 = new Product();
        product2.SetProductName("Bread");
        product2.SetProductId(1234);
        product2.SetPrice(10);
        product2.SetQuantity(2);


        Order order1 = new Order();
        order1.TotalCost();
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.SetCustomer(customer1);

        Console.WriteLine(customer1.GetShippingLable());
        order1.PackingLabel();
        Console.WriteLine($"Total: ${order1.TotalCost()}");
        
           

        // Add all your products



        Address address2 = new Address();
        address2.SetStreetAddress("564 east road");
        address2.SetCity("Addis Ababa");
        address2.SetState("Mercato");
        address2.SetCountry("Ethiopia");
        
        Customer customer2 = new Customer();
        customer2.SetAddress(address2);
        customer2.SetName("Melkam Abate");





        Product product12 = new Product();
        product12.SetProductName("Milk");
        product12.SetProductId(4532);
        product12.SetPrice(9);
        product12.SetQuantity(2);
        // set everything

        Product product22 = new Product();
        product22.SetProductName("Bread");
        product22.SetProductId(1234);
        product22.SetPrice(10);
        product22.SetQuantity(2);


        Order order12 = new Order();
        order12.TotalCost();
        order12.AddProduct(product12);
        order12.AddProduct(product22);
        order12.SetCustomer(customer2);

        Console.WriteLine(customer2.GetShippingLable());
        order12.PackingLabel();
        Console.WriteLine($"Total: ${order12.TotalCost()}");

    }
}