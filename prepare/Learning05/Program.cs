using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square box = new Square("Yellow", 2);
        shapes.Add(box);
        Rectangle longBox = new Rectangle("Blue", 4, 6);
        shapes.Add(longBox);
        Circle roundShape = new Circle("Plum", 3);
        shapes.Add(roundShape);

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Shape color is {s.GetColor()} and area is {s.GetArea()}");
        }

    }
}