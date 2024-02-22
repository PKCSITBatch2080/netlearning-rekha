using System;

class DataTypes
{
    public void Learn()
    {
        // numbers
        byte age = 14;
        byte dayOfWeek = 11;       // camel casing
      //  byte DayOfWeek = 11;       // pascal casing

        byte a = 12;
        short b = 23456;
        int c = 234234234;
        long d = 1236879498;

        float weight1 = 45.6f;
        double weight2 = 4567.77777;
        decimal weight3 = 3479.7986926m;

        // text
        char initial = 'D';
        string name = "Rekha";

        bool isFemale = false;
        DateTime date = DateTime.Now;  // Corrected casing and removed parentheses

        // Using variables in console output
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Day of Week (camel): {dayOfWeek}");
        Console.WriteLine($"Variable 'a': {a}");
        Console.WriteLine($"Variable 'b': {b}");
        Console.WriteLine($"Variable 'c': {c}");
        Console.WriteLine($"Variable 'd': {d}");
        Console.WriteLine($"Weight 1: {weight1}");
        Console.WriteLine($"Weight 2: {weight2}");
        Console.WriteLine($"Weight 3: {weight3}");
        Console.WriteLine($"Initial: {initial}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Is Female: {isFemale}");
        Console.WriteLine($"Current Date: {date}");

        // Ensure to use proper casing for DateTime.Now and end the statement with a semicolon.
    }
}

 partial class Program
{
    static void Main()
    {
        DataTypes dataTypes = new DataTypes();
        dataTypes.Learn();
    }
}
