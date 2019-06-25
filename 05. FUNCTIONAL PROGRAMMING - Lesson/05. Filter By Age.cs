using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            Dictionary<string, int> names = new Dictionary<string, int>();

            for (int i = 0; i < numberLines; i++)
            {
                List<string> inputInfo = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string name = inputInfo[0];

                int inputAge = int.Parse(inputInfo[1]);

                names.Add(name, inputAge);
            }

            string condition = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            string format = Console.ReadLine();

            var filteredNames =  FilterByAge(condition, age, names);

            PrintDictionary(format, filteredNames);
        }

        public static Dictionary<string,int> FilterByAge (string condition, int age, Dictionary<string,int>names)
        {
            Dictionary<string, int> filteredNames = new Dictionary<string, int>();

            if(condition == "younger")
            {
                filteredNames = names
                    .Where(x => x.Value < age)
                    .ToDictionary(x => x.Key, x => x.Value);
            }
            else if(condition == "older")
            {
                filteredNames = names
                    .Where(x => x.Value >= age)
                    .ToDictionary(x => x.Key, x => x.Value);
            }

            return filteredNames;
        }

        public static void PrintDictionary(string format, Dictionary<string,int> names)
        {
            if(format == "name")
            {
                foreach (var item in names)
                {
                    Console.WriteLine($"{item.Key}");
                }
            }
            else if (format == "age")
            {
                foreach (var item in names)
                {
                    Console.WriteLine($"{item.Value}");
                }
            }
            else if(format == "name age")
            {
                foreach(var item in names)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }

    }
}
