using System;

namespace LearningCSharp.Loops;

public class ForEachLoop
{
    public static void Run()
    {
        int[] arr = [1,3,5,4,3];
        foreach (var item in arr)
        {
            System.Console.WriteLine(item);
        }
    }
}
