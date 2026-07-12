using System;
using System.Security.Cryptography;

namespace LearningCSharp.ConditionalStatements;

public class IfElse
{
    public static void Run()
    {
        int age = 23;
        if (age >= 18)
        {
            System.Console.WriteLine("You can vote!");
        } else
        {
            System.Console.WriteLine("You cannot vote!");
        }
    }
}
