using System;

class Program
{
    static void Main()
    {
        // 1. Array of 5 favorite numbers
        int[] numbers = { 2, 6, 9, 3, 8 };

        // 2. Sort in ascending order
        Array.Sort(numbers);
        Console.WriteLine("After Array.Sort() (ascending):");
        PrintArray(numbers);

        // 3. Reverse the sorted array
        Array.Reverse(numbers);
        Console.WriteLine("After Array.Reverse() (descending):");
        PrintArray(numbers);

        // 4. Find the position of a specific number
        int searchFor = 9;
        int index = Array.IndexOf(numbers, searchFor);
        Console.WriteLine($"Index of {searchFor} in the array: {index}");
    }

    // 5. Print each element using a for loop
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"  numbers[{i}] = {arr[i]}");
        }
    }
}