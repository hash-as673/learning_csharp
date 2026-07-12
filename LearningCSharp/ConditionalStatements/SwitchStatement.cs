using System;

namespace LearningCSharp.ConditionalStatements;

public class SwitchStatement
{
    public static void Run()
    {
        int q = 3;
        string quarterLabel = q switch
        {
            1 => "Q1",
            2 => "Q2",
            3 => "Q3",
            4 => "Q4",
            _ => "Invalid"
        };
        System.Console.WriteLine(quarterLabel);
    }
}
