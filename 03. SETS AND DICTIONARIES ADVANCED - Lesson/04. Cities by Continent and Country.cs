using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRows = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < numberRows; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                string continent = input[0];

                string country = input[1];

                string city = input[2];

                if (continents.ContainsKey(continent))
                {
                    if (continents[continent].ContainsKey(country))
                    {
                        continents[continent][country].Add(city);
                    }
                    else
                    {
                        continents[continent].Add(country, new List<string>() { city });
                    }
                }
                else
                {
                    Dictionary<string, List<string>> currentCountries = new Dictionary<string, List<string>>();

                    currentCountries.Add(country, new List<string>() { city });

                    continents.Add(continent, currentCountries);
                }
            }

            foreach(var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach(var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
