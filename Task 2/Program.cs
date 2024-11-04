// Завдання 2: Фрукт

class Fruit
{
    public string Name { get; set; }
}

class Apple : Fruit
{
    public string Variety { get; set; }
    public string Color { get; set; }
}

class Pear : Fruit
{
    public string Variety { get; set; }
    public string Color { get; set; }
}

// Використання об'єктів фруктів
static void TestFruits()
{
    Apple apple = new Apple { Name = "Apple", Variety = "Red Delicious", Color = "Red" };
    Pear pear = new Pear { Name = "Pear", Variety = "Bartlett", Color = "Green" };

    Console.WriteLine($"Apple - Name: {apple.Name}, Variety: {apple.Variety}, Color: {apple.Color}");
    Console.WriteLine($"Pear - Name: {pear.Name}, Variety: {pear.Variety}, Color: {pear.Color}");
}