using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, long> totalPopulation = new Dictionary<string, long>();

        Dictionary<string, Dictionary<string, long>> countriesAndCities = new
            Dictionary<string, Dictionary<string, long>>();

        string input;
        while ((input = Console.ReadLine()) != "report")
        {
            string[] tokens = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
            string city = tokens[0];
            string country = tokens[1];
            int population = int.Parse(tokens[2]);
            if (!totalPopulation.ContainsKey(country))
            {
                totalPopulation.Add(country, 0);
                countriesAndCities.Add(country, new Dictionary<string, long>());
            }
            totalPopulation[country] += population;
            countriesAndCities[country].Add(city, population);
        }
        foreach (var country in totalPopulation.OrderByDescending(c => c.Value))
        {
            Console.WriteLine($"{country.Key} (total population: {country.Value})");
            Dictionary<string, long> cities = countriesAndCities[country.Key]
                .OrderByDescending(x=>x.Value)
                .ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var city in cities)
            {
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }

        }
    }
}

