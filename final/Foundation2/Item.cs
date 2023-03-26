using System;

public class Item
{
    private int _id;
    private string _name;
    private double _price;

    public Item(int id, string name, double price)
    {
        _id = id;
        _name = name;
        _price = price;
    }

    public int Id()
    {
        return _id;
    }
    public string Name()
    {
        return _name;
    }
    public double Price()
    {
        return _price;
    }
}