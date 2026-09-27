using System;

namespace Week2Exercise.Classes;

public class Dog : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Woof!");
    }
    public override void run()
    {
        Console.WriteLine("Dogs run faster!");
    }
}
