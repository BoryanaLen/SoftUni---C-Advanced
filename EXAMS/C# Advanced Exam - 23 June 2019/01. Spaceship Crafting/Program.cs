using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> chemicalLiquids = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            List<int> physicalItems = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            Dictionary<int, string> items = new Dictionary<int, string>
            {
                {25, "Glass" },
                {50, "Aluminium" },
                {75, "Lithium" },
                {100, "Carbon fiber" }
            };

            Dictionary<string, int> createdItems = new Dictionary<string, int>
            {
                {"Glass", 0 },
                {"Aluminium", 0 },
                {"Lithium", 0 },
                {"Carbon fiber", 0 }
            };


            while (chemicalLiquids.Count > 0 && physicalItems.Count > 0)
            {
                int currentChemic = chemicalLiquids[0];

                int currentPhysic = physicalItems[physicalItems.Count - 1];

                int sum = currentChemic + currentPhysic;

                if (items.ContainsKey(sum))
                {
                    createdItems[items[sum]]++;
                    physicalItems.RemoveAt(physicalItems.Count - 1);
                    chemicalLiquids.RemoveAt(0);
                }
                else
                {
                    chemicalLiquids.RemoveAt(0);
                    physicalItems[physicalItems.Count - 1] += 3;
                }
            }

            bool areAllMaterials = false;
            int count = 0;

            foreach(var item in createdItems)
            {
                if (item.Value > 0)
                {
                    count++;
                }
            }

            if (count == 4)
            {
                areAllMaterials = true;
            }

            if (areAllMaterials)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (chemicalLiquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", chemicalLiquids)}");
            }

            if (physicalItems.Count == 0)
            {
                Console.WriteLine("Physical items left: none");
            }
            else
            {
                physicalItems.Reverse();

                Console.WriteLine($"Physical items left: {string.Join(", ", physicalItems)}");
            }

            var orderedItems = createdItems.OrderBy(x => x.Key);

            foreach(var item in orderedItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
