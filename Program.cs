using Week2Exercise.Classes;

namespace Week2Exercise;

class Program
{
    static void Main(string[] args)
    {
        Cat cat1 = new Cat();
        cat1.Name = "Doris";
        cat1.Type = "Bengal";
        cat1.NumberOfLegs = 4;
        cat1.NumberOfWhiskers = 16;

        Console.WriteLine($"Name: {cat1.Name}, Type: {cat1.Type}, Number of legs: {cat1.NumberOfLegs}, This cat has {cat1.NumberOfWhiskers} whiskers");
        cat1.makeSound();
        cat1.run();



    }
}
