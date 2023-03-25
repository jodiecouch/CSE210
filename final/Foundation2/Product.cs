using System;

public class Products
{
    private int _id;
    private string _name;
    private double _price;
    private int _qty;

    public Products(int id, string name, double price)
    {
        _id = id;
        _name = name;
        _price = price;
        _qty = 1;

    }

    public double lineItemPrice()
    {
        return (Convert.ToDouble(_qty) * _price);
    }
    public string lineItem()
    {
        return ($"Item: {_name} Id: {_id} Price: {_price} Quantity: {_qty} Total Price: {lineItemPrice()}");
    }
    public void SetQuantity(int newQty)
    {
        _qty = newQty;
    }
}