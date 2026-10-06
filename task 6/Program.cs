using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        // 1. Create a list with 3 favorite fruits
        List<string> fruits = new List<string> { "Mango", "Apple", "Banana" };

        // 2. Add a new fruit
        fruits.Add("Orange");

        // 3. Remove one fruit
        fruits.Remove("Apple");

        // 4. Print all fruits using foreach
        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine($"  {fruit}");
        }
        
        // 5. Create a dictionary with IDs 1, 2, 3 as keys
        Dictionary<int, string> fruitDict = new Dictionary<int, string>
        {
            { 1, "Mango" },
            { 2, "Apple" },
            { 3, "Banana" }
        };

        // 6. Add a new entry and print all key-value pairs
        fruitDict.Add(4, "Orange");

        Console.WriteLine("Fruit dictionary:");
        foreach (KeyValuePair<int, string> pair in fruitDict)
        {
            Console.WriteLine($"  ID {pair.Key} : {pair.Value}");
        }
    }
}