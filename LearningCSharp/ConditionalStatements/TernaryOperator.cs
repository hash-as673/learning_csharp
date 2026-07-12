namespace LearningCSharp.ConditionalStatement;

public class TernaryOperator
{
    public static void Run()
    {
        int x = 3;
        bool isEven = (x % 2 ==0 ) ? true : false;
        System.Console.WriteLine(isEven);
    }
}