using System;

namespace Week2Exercise.Classes;

public class Cat : Animal
{
    public int NumberOfWhiskers;
    public override void makeSound()
    {
        Console.WriteLine("Meow");
    }
    public override void run()
    {
        Console.WriteLine("Cats run fast");
    }
}
