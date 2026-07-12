namespace LearningCSharp.Collections;

public class Stack
{
    public static void Run()
    {
        Stack<int> stack = [];
        stack.Push(10); // Adds to top
        stack.Push(20);

        int topItem = stack.Pop(); // Removes 20 (the last one added)
        int peekItem = stack.Peek(); // Looks at 10 without removing it
    }
}