using System;

namespace LearningCSharp.OOP;

public readonly struct Point(int x, int y)
{
    public int X { get; } = x;
    public int Y { get; } = y;
      public readonly double GetDistance() => Math.Sqrt(X * X + Y * Y);
}
