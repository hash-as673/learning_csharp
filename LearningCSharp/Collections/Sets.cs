namespace LearningCSharp.Collections;

public class Sets
{
    public static void Run()
    {
        HashSet<string> set = [];
        set.Add("Apple");
        set.Add("Apple"); // Will be ignored; duplicates are not allowed
        
        bool exists = set.Contains("Apple"); // Returns true; O(1) performance
    }
}