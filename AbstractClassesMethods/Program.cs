using System;

abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius < 0) throw new ArgumentOutOfRangeException(nameof(radius), "Radius cannot be negative.");
        Radius = radius;
    }

    public override double GetArea() => Math.PI * Radius * Radius;
}

class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        if (width < 0) throw new ArgumentOutOfRangeException(nameof(width), "Width cannot be negative.");
        if (height < 0) throw new ArgumentOutOfRangeException(nameof(height), "Height cannot be negative.");
        Width = width;
        Height = height;
    }

    public override double GetArea() => Width * Height;
}

class Program
{
    static void Main()
    {
        Shape circle = new Circle(3.5);
        Shape rectangle = new Rectangle(4.0, 5.0);

        Console.WriteLine($"Circle (radius {((Circle)circle).Radius}): area = {circle.GetArea():F2}");
        Console.WriteLine($"Rectangle (width {((Rectangle)rectangle).Width}, height {((Rectangle)rectangle).Height}): area = {rectangle.GetArea():F2}");
    }
}