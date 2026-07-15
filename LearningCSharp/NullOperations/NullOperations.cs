using System;
using System.Collections.Generic;

namespace LearningCSharp.NullOperations;

public class Address
{
    public string? City { get; set; } // Nullable string
}

public class User
{
    public Address? Address { get; set; } // Nullable complex object
    public List<string>? Roles { get; set; }
}

public class NullOperations
{
    public static void Run()
    {
        // Let's create a user whose Address object is completely missing (null)
        User? user = new User { Address = null };

        // 1. Null-Conditional Operator (?.)
        // This safely stops navigating if 'user' or 'Address' is null.
        // Instead of crashing, 'city' simply becomes null.
        string? city = user?.Address?.City;
        Console.WriteLine($"1. City value is: {(city == null ? "null" : city)}");

        // 2. Null-Coalescing Operator (??)
        // This provides a fallback value if the left side evaluates to null.
        string finalCity = user?.Address?.City ?? "Default City";
        Console.WriteLine($"2. Final City (with fallback): {finalCity}");

        // 3. Null-Coalescing Assignment Operator (??=)
        // This initializes the object ONLY if it is currently null.
        user.Roles ??= new List<string>();
        user.Roles.Add("Admin"); // Safe to call now without crashing!
        Console.WriteLine($"3. Roles count after assignment: {user.Roles.Count}");

        // 4. Null-Forgiving / Bang Operator (!)
        // Used to tell the compiler: "I am absolutely sure this isn't null, silence warnings."
        // We know we just initialized Roles above, so we can force it:
        int rolesLength = user.Roles!.Count; 
        Console.WriteLine($"4. Verified roles count: {rolesLength}");
    }
}