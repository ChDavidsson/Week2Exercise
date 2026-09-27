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

        Dog dog1 = new Dog();
        dog1.Name = "Hasse";
        dog1.Type = "Labrador";
        dog1.NumberOfLegs = 4;
        
        Console.WriteLine($"Name: {dog1.Name}, Type: {dog1.Type}");
        dog1.makeSound();
        dog1.run();

        Goat goat1 = new Goat();
        goat1.Name = "Mårten";
        goat1.NumberOfLegs = 4;
        goat1.Beard = "This goat has a long beard";
        
        Console.WriteLine($"Name: {goat1.Name}, {goat1.Beard}");
        goat1.makeSound();
        goat1.run();
    }
}
