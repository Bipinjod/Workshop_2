using System;

class Program
{
    static void Main()
    {
        // 1. Birthdate 
        DateTime birthDate = new DateTime(2007, 5 , 16);

        // 2. Current date and time
        DateTime now = DateTime.Now;

        // 3. Calculate age using TimeSpan
        TimeSpan ageSpan = now - birthDate;
        int ageInYears = (int)(ageSpan.TotalDays / 365.25);

        // 4. Print birthdate, current date and age
        Console.WriteLine($"Birthdate    : {birthDate:yyyy-MM-dd}");
        Console.WriteLine($"Current date : {now:yyyy-MM-dd HH:mm:ss}");
        Console.WriteLine($"Age          : {ageInYears} years ({ageSpan.Days} days)");

        // 5. Add 10 days to the birthdate
        DateTime birthPlus10 = birthDate.AddDays(10);
        Console.WriteLine($"Birthdate + 10 days : {birthPlus10:yyyy-MM-dd}");
    }
}