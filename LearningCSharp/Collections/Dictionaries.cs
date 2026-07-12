namespace LearningCSharp.Collections;

public class Dictionary
{
    public static void Run()
    {
        Dictionary<int, string> dict = [];
        dict.Add(1, "Alice");
        dict.Add(2, "Bob");

// Fast access by key
        string name = dict[1]; // Returns "Alice"

// Check if key exists
        if (dict.ContainsKey(2)) { /* do something */ }
    }
}