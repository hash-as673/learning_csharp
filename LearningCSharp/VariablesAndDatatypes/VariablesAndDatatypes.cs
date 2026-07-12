using System;

namespace LearningCSharp.VariablesAndDatatypes;

public class VariablesAndDatatypes
{
    public static void Run()
    {
        int i = 34;
        float f = 3.14f;
        double d = 33.42342;
        char c = 'a';
        string s = "Hello";
        bool b = true;
        decimal money = 29.99m;
        Console.WriteLine(i.GetType().Name);
        Console.WriteLine(f.GetType().Name);
        Console.WriteLine(d.GetType().Name);
        Console.WriteLine(c.GetType().Name);
        Console.WriteLine(s.GetType().Name);
        Console.WriteLine(b.GetType().Name);
        Console.WriteLine(money.GetType().Name);
    }
}
