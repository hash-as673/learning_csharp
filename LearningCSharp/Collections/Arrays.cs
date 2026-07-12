namespace LearningCSharp.Collections;

public class Arrays
{
    public static void Run(string[] args)
    {
        int[] arr = [1, 2, 3, 4, 5];
        Console.WriteLine("Iterating using for loop:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        Console.WriteLine("Iterating using for each loop:");
        foreach (var i in  arr)
        {
            Console.WriteLine(i);
        }
        
        
    }   
}