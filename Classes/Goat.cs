using System;

namespace Week2Exercise.Classes;

public class Goat : Animal
{
    public string? Beard;
    public override void makeSound()
    {
        Console.WriteLine("Baahh");
    }

    public override void run()
    {
        Console.WriteLine("Goats don't run fast");
    }
}
