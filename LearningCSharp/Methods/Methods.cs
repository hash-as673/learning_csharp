using System;

namespace LearningCSharp.Methods;

public class Methods
{
    public static int Add (int x, int y) => x + y;

    public static int DoubleByTwo(int x)
    {
        return x * 2;
    }

    public static void AlterValue(ref int x)
    {
        x = 100;
    }

    public static void GiveValue(out int x)
    {
        x = 34;
    }

    public static void Run()
    {
        System.Console.WriteLine(Add(4,5));
        System.Console.WriteLine(DoubleByTwo(3));
        int x = 2;
        System.Console.WriteLine(x);
        AlterValue(ref x);
        System.Console.WriteLine(x);
        GiveValue(out int y);
        System.Console.WriteLine(y);
    }
}
