

namespace LearningCSharp.UserInput;

public class UserInput
{
    public static void Run()
    {
        System.Console.WriteLine("Enter a number:");
        int i = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter a string:");
        string s = Console.ReadLine();
        System.Console.WriteLine($"You have entered {i} and {s}");
    }
}
