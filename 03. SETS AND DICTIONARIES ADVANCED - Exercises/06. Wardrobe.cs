using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLinesOfClothes = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberLinesOfClothes; i++)
            {
                List<string> inputRow = Console.ReadLine().Split(" -> ").ToList();

                string color = inputRow[0];

                List<string> clothes = inputRow[1].Split(',').ToList();

                if (wardrobe.ContainsKey(color))
                {
                    foreach(var product in clothes)
                    {
                        if (wardrobe[color].ContainsKey(product))
                        {
                            wardrobe[color][product]++;
                        }
                        else
                        {
                            wardrobe[color].Add(product, 1);
                        }
                    }
                }
                else
                {
                    wardrobe.Add(color, new Dictionary<string, int>());

                    foreach (var element in clothes)
                    {
                        if (wardrobe[color].ContainsKey(element))
                        {
                            wardrobe[color][element]++;
                        }
                        else
                        {
                            wardrobe[color].Add(element, 1);
                        }
                    }
                }
            }

            IList<string> commandInfo = Console.ReadLine().Split().ToList();

            string colorToFind = commandInfo[0];

            string item = commandInfo[1];

            foreach(var element in wardrobe)
            {
                Console.WriteLine($"{element.Key} clothes:");

                foreach(var product in element.Value)
                {
                    if(product.Key == item && element.Key == colorToFind)
                    {
                        Console.WriteLine($"* {product.Key} - {product.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {product.Key} - {product.Value}");
                    }
                }
            }
        }
    }
}
