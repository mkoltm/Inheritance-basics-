﻿// Завдання 3: Тварини

public abstract class Animal
{
    public float Weight { get; set; }
    public string Color { get; set; }

    public Animal(string color, float weight)
    {
        Color = color;
        Weight = weight;
    }

    public abstract string MakeSound();
}

public abstract class AnimalWithTail : Animal
{
    public float TailLength { get; set; }

    public AnimalWithTail(string color, float weight, float tailLength) : base(color, weight)
    {
        TailLength = tailLength;
    }
}

public class Cat : AnimalWithTail
{
    public Cat(string color, float weight, float tailLength) : base(color, weight, tailLength)
    {
    }

    private string Purr()
    {
        return "purrrrrrrr";
    }

    private string Meow()
    {
        return "Meow";
    }

    public override string MakeSound()
    {
        return Purr() + Meow();
    }

    public override string ToString()
    {
        return $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
    }
}

public class Dog : AnimalWithTail
{
    public Dog(string color, float weight, float tailLength) : base(color, weight, tailLength)
    {
    }

    public override string MakeSound()
    {
        return "Woof";
    }

    public override string ToString()
    {
        return $"This is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
    }
}

// Використання тварин
static void TestAnimals()
{
    Cat cat = new Cat("Black", 5.5f, 10.2f);
    Dog dog = new Dog("Brown", 10.0f, 15.5f);

    Console.WriteLine(cat.MakeSound());
    Console.WriteLine(dog.MakeSound());

    Console.WriteLine(cat);
    Console.WriteLine(dog);
}