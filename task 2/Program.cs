using System;

class Program
{
    static void Main()
    {
        // Circle.PI = 3.14159; Intentional Compilation error
        
        Console.WriteLine($"PI = {Circle.PI}");

        double radius = 5;
        Console.WriteLine($"Area of circle (r = {radius}): {Circle.CalculateArea(radius)}");
        Console.WriteLine($"Perimeter of circle (r = {radius}): {Circle.CalculatePerimeter(radius)}");
    }
}