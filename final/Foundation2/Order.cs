using System;

public class Order
{
    private Customer _customer;
    private List<Products> _products = new List<Products>();

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddToOrder(Item item, int Qty)
    {
        Products product = new Products(item.Id(), item.Name(), item.Price(), Qty);
        _products.Add(product);
    }

    private double shipping()
    {
        if (_customer.residentUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    private double CalculateTotalOrderPrice()
    {
        double total = 0;
        foreach (Products p in _products)
        {
            total += p.lineItemPrice();
        }
        total += shipping();
        return total;
    }
    public void PackingLabel()
    {

        //ShippingLabel();

        Console.Write("Order");
        string lineItems = "";
        foreach (Products p in _products)
        {
            lineItems = lineItems + Environment.NewLine + p.lineItem();
        }
        Console.WriteLine(lineItems);
        Console.WriteLine($"Shipping: {shipping()}");
        Console.WriteLine($"Order Total: {CalculateTotalOrderPrice()}");

    }

    public void ShippingLabel()
    {
        string header = $"{_customer.GetName()}\r\n{_customer.GetAddress()}";
        Console.WriteLine(header);
    }


}