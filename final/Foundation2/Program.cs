using System;

class Program
{
    static void Main(string[] args)
    {

        //Console.WriteLine("Hello Foundation2 World!");

        //create customers
        Customer bob = new Customer("Buster Bob", "123 Bronco Street", "Denton", "TX", "USA");
        Customer fluffy = new Customer("Fluffy", "PO BOX 76", "El Salva", "Juarez", "Mexico");

        //Console.WriteLine(fluffy.GetName());
        //Console.WriteLine(fluffy.GetAddress());

        //create orders
        Order order1 = new Order(bob);
        Order order2 = new Order(fluffy);

        //create items 
        Item wuzzle = new Item(1, "Wuzzle", 10.25);
        Item wizzle = new Item(2, "Wizzle", 5.00);
        Item wample = new Item(3, "Wample", 20.25);

        //add products to orders
        order1.AddToOrder(wuzzle, 1);
        order2.AddToOrder(wuzzle, 2);

        order1.AddToOrder(wizzle, 1);
        order2.AddToOrder(wizzle, 2);

        order1.AddToOrder(wample, 1);
        order2.AddToOrder(wample, 2);

        order1.ShippingLabel();
        order1.PackingLabel();
        Console.WriteLine();
        order2.ShippingLabel();
        order2.PackingLabel();

    }
}