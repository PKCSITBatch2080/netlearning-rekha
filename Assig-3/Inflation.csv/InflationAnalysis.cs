
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class InflationAnalysis
{
    public List<Inflation> AsianPacificInflations { get; set; } = new List<Inflation>();

    public void ReadCsvData(string filePath)
    {
       try
        {
            var lines = File.ReadAllLines(filePath);

            if (lines.Length < 2)
            {
                Console.WriteLine("Error: The CSV file does not contain enough data.");
                return;
            }

            // Skip the header row
            for (int i = 1; i < lines.Length; i++)
            {
                var columns = lines[i].Split(',');

                if (columns.Length == 6)
                {
                    var inflationData = new Inflation
                    {
                        RegionalMember = columns[0].Trim(),
                        Year = int.Parse(columns[1]),
                        InflationRate = double.Parse(columns[2]),
                        UnitOfMeasurement = columns[3].Trim(),
                        Subregion = columns[4].Trim(),
                        CountryCode = columns[5].Trim()
                    };

                    AsianPacificInflations.Add(inflationData);
                }
                else
                {
                    Console.WriteLine($"Error: Invalid data format in line {i + 1}. Skipping this line.");
                }
            }

            Console.WriteLine("Data loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading CSV data: {ex.Message}");
        }
    }
    

    public List<Inflation> FindInflationRatesForYear(int year)
    {
        return AsianPacificInflations.Where(i => i.Year == year).ToList();
    }

    public Inflation FindYearWithHighestInflation(string country)
    {
        return AsianPacificInflations.Where(i => i.RegionalMember == country)
                                      .OrderByDescending(i => i.InflationRate)
                                      .FirstOrDefault();
    }
    public List<string> ListTopRegionsWithHighestInflation()
        {
         var topRegions = AsianPacificInflations.GroupBy(i => i.RegionalMember)
                                           .Select(g => new
                                           {
                                               Region = g.Key,
                                               MaxInflation = g.Max(i => (double?)i.InflationRate)
                                           })
                                           .Where(g => g.MaxInflation.HasValue)
                                           .OrderByDescending(g => g.MaxInflation)
                                           .Take(10)
                                           .Select(g => g.Region)
                                           .ToList();

         return topRegions;
        }

    

    public List<string> ListTopSouthAsianCountriesWithLowestInflationForYear(int year)
    {
        var southAsianCountries = AsianPacificInflations
            .Where(i => i.Subregion == "South Asia" && i.Year == year)
            .OrderBy(i => i.InflationRate)
            .Take(3)
            .Select(i => i.CountryCode)
            .ToList();

        return southAsianCountries;
    }
}

