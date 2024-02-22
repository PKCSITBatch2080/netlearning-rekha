using System;

class Methods
{
    public void Greet(string greeting)
    {
        Console.WriteLine($"{greeting}, there!"); // String interpolation
    }

    public float CalculateBMI(float weightInKg, float heightInFt)
    {
        var heightInM = heightInFt * 0.3048f; // Corrected the assignment operator and added the conversion factor
        var bmi = weightInKg / (heightInM * heightInM); // Corrected the formula
        return bmi; // Added return statement
    }
}
