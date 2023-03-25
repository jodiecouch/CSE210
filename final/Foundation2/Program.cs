using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Foundation2 World!");

        //create customers
        Customer bob = new Customer("Buster Bob", "123 Bronco Street", "Denton", "TX", "USA");
        Customer fluffy = new Customer("Fluffy", "PO BOX 76", "El Salva", "Juarez", "Mexico");

        Console.WriteLine(fluffy.GetName());
        Console.WriteLine(fluffy.GetAddress());


        //create orders
        Order order1 = new Order(bob);
        Order order2 = new Order(fluffy);

        //create products 
        Products wuzzle = new Products(1, "Wuzzle", 10.25);
        Products wizzle = new Products(2, "Wizzle", 5.00);
        Products wample = new Products(3, "Wample", 20.25);

        //add products to orders
        order1.AddToOrder(wuzzle);
        wuzzle.SetQuantity(2);
        order2.AddToOrder(wuzzle);
        order1.AddToOrder(wizzle);
        wizzle.SetQuantity(2);
        order2.AddToOrder(wizzle);
        order1.AddToOrder(wample);
        wample.SetQuantity(2);
        order2.AddToOrder(wample);

        Console.WriteLine("You made it!");



    }
}