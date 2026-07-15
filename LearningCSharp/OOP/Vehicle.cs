
namespace LearningCSharp.OOP;

public abstract class Vehicle (int speed, int noOfWheels, string model) : IMovable
{
    public int Speed {get;} = speed;
    public int NoOfWheels {get ; } = noOfWheels;

    public string Model {get; } = model;

    public abstract void Accelerate();
    public abstract void Breaks();

   public virtual void PrintDetails()
    {
        Console.WriteLine($"Model: {Model}, Wheels: {NoOfWheels}, Top Speed: {Speed} km/h");
    }

}
