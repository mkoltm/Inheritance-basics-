using System;

// Завдання 1: Фігура

class Figure
{
    public virtual double CalculateArea()
    {
        return 0;
    }

    public virtual double CalculatePerimeter()
    {
        return 0;
    }
}

class Circle : Figure
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}

// Використання об'єктів фігур
static void TestFigures()
{
    Circle circle = new Circle { Radius = 5 };
    Rectangle rectangle = new Rectangle { Width = 4, Height = 6 };

    Console.WriteLine($"Circle - Area: {circle.CalculateArea()}, Perimeter: {circle.CalculatePerimeter()}");
    Console.WriteLine($"Rectangle - Area: {rectangle.CalculateArea()}, Perimeter: {rectangle.CalculatePerimeter()}");
}