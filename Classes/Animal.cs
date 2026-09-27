using System;
using System.IO.Compression;

namespace Week2Exercise.Classes;

public abstract class Animal
{
    public string Name {get ; set ;}
    public string Type {get ; set ;}
    public int NumberOfLegs {get ; set ;}
    public abstract void makeSound();
    public abstract void run();
}
