using System;

public class Order
{
    private Customer _customer;
    private List<Products> _products = new List<Products>();

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddToOrder(Products product)
    {
        _products.Add(product);
    }

    private double CalculateTotalOrderPrice()
    {
        double total = 0;
        foreach (Products p in _products)
        {
            total += p.lineItemPrice();
        }
        if (_customer.residentUSA())
        { total += 5; }
        else
        {
            total += 35;
        }
        return total;
    }
    public void PackingLabel()
    {
        string header = $"{_customer.GetName()}\r\n{_customer.GetAddress()}";
        Console.WriteLine(header);

        Console.Write("Items");
        string lineItems = "";
        foreach (Products p in _products)
        {
            lineItems = Environment.NewLine + p.lineItem();
        }
        Console.WriteLine(lineItems);

        Console.WriteLine($"Order Total: {CalculateTotalOrderPrice()}");

    }

    public void ShippingLabel()
    {

    }


}