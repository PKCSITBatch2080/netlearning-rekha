// Program.cs
using System;

class Program
{
    static void Main()
    {
        string filePath = "Assignment3\\Inflation.csv";

        InflationAnalysis analysis = new InflationAnalysis();
        analysis.ReadCsvData(filePath);

        // Example usage of the methods:
        var inflationRatesFor2021 = analysis.FindInflationRatesForYear(2021);
        var highestInflationNepal = analysis.FindYearWithHighestInflation("Nepal");
        var top10RegionsHighestInflation = analysis.ListTopRegionsWithHighestInflation();
        var top3SouthAsianCountries2020 = analysis.ListTopSouthAsianCountriesWithLowestInflationForYear(2020);

        // You can add code here to print or process the results.
    }
}
