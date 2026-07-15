using System;
using System.Globalization;

namespace LearningCSharp.EventsAndDelages;

public delegate void MessageEnvelope(string text);

public class Robot
{
    public void SaySomething(string text) => System.Console.WriteLine($"Robot says {text}");
    public void FlashLights(string text)=> System.Console.WriteLine($"[Lights Flashing Red]: {text.ToUpper()}!!!");
}
public class Delagets
{   
    public static void Run()
    {
        Robot wallE = new();
        MessageEnvelope myEnvelope = wallE.SaySomething;
        myEnvelope += wallE.FlashLights;
        myEnvelope("Beep Boop");
        Console.WriteLine("\n--- Removing a method ---");

        myEnvelope -= wallE.SaySomething;
     
        myEnvelope("Low Battery");
    }
}
