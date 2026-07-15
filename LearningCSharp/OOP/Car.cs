
namespace LearningCSharp.OOP;

public class Car(int speed, int noOfWheels, string model , string color ) : Vehicle(speed,  noOfWheels, model ) 
{
    public string Color {get;} = color;
    public override void Accelerate()
    {
        Console.WriteLine($"{this.GetType().Name} is accelerating");
    }

    public override void Breaks()
    {
        Console.WriteLine($"{this.GetType().Name} applied breaks");
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        System.Console.WriteLine($"The car is {this.Color} ");
    }
}
