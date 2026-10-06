using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Declare and initialize each type
        byte byteVar = 255;
        short shortVar = 32000;
        int intVar = 2000000000;
        long longVar = 9000000000L;
        float floatVar = 3.14f;
        double doubleVar = 3.14159265;
        decimal decimalVar = 19.99m;
        char charVar = 'A';
        bool boolVar = true;

        // Type conversions
        string numberAsString = 42.ToString();
        double stringToDouble = double.Parse("3.14", CultureInfo.InvariantCulture);

        // Print with labels showing type and value
        Console.WriteLine($"byte    : {byteVar}");
        Console.WriteLine($"short   : {shortVar}");
        Console.WriteLine($"int     : {intVar}");
        Console.WriteLine($"long    : {longVar}");
        Console.WriteLine($"float   : {floatVar}");
        Console.WriteLine($"double  : {doubleVar}");
        Console.WriteLine($"decimal : {decimalVar}");
        Console.WriteLine($"char    : {charVar}");
        Console.WriteLine($"bool    : {boolVar}");
        Console.WriteLine($"int 42 -> string      : \"{numberAsString}\" (type: {numberAsString.GetType().Name})");
        Console.WriteLine($"string \"3.14\" -> double : {stringToDouble} (type: {stringToDouble.GetType().Name})");
    }
}