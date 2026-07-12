
namespace LearningCSharp.Collections;

public class List
{
    public static void Run()
    {
        // 1. Initialization
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };

        // 2. Adding Elements
        list.Add(6);                // Adds to end: [1, 2, 3, 4, 5, 6]
        list.Insert(0, 0);          // Inserts at index: [0, 1, 2, 3, 4, 5, 6]
        
        // 3. Removing Elements
        list.Remove(3);             // Removes the first occurrence of value 3
        list.RemoveAt(0);           // Removes the element at index 0

        // 4. Searching/Checking
        bool contains = list.Contains(5);    // Returns true if found
        int index = list.IndexOf(5);         // Returns index of 5, or -1 if not found

        // 5. Count/Capacity
        int count = list.Count;              // Current number of elements

        // 6. Sorting/Reversing
        list.Sort();                // Sorts in ascending order
        list.Reverse();             // Reverses the current order

        // 7. Clearing
        // list.Clear();            // Removes all elements

        // Traversing
        Console.WriteLine("Final list elements:");
        foreach (var element in list)
        {
            Console.WriteLine(element);
        }
    }
}