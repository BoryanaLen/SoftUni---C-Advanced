using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            List<double> noDuplicatedNumbers = numbers.Distinct().ToList();

            Dictionary<double, int> dictionaryNumbers = new Dictionary<double, int>();

            for (int i = 0; i < noDuplicatedNumbers.Count; i++)
            {
                int count = numbers.Count(x => x == noDuplicatedNumbers[i]);

                dictionaryNumbers.Add(noDuplicatedNumbers[i], count);
            }

            foreach(var item in dictionaryNumbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
