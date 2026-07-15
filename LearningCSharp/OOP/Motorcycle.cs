using System;

namespace LearningCSharp.OOP;

public class Motorcycle(int speed, string model) : Vehicle(speed, 2, model)
{
    public override void Accelerate() => Console.WriteLine("Motorcycle twists the throttle!");
    public override void Breaks() => Console.WriteLine("Motorcycle squeals to a halt.");
}