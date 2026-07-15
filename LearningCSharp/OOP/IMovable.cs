
namespace LearningCSharp.OOP;

public interface IMovable
{
    void Move()
    {
        Console.WriteLine($"{this.GetType().Name} is moving");
    }
}
