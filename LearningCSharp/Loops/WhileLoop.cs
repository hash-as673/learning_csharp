using System;

namespace LearningCSharp.Loops;

public class WhileLoop
{
    public static void Run()
    {   
        int i = 10;
        while (i>0)
        {
            System.Console.WriteLine(i);
            i--;
        }
    }
}
