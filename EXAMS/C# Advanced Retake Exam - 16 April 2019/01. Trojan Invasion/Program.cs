using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Trojan_Invasion
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());

            List<int> plates = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 1; i <= waves; i++)
            {
                List<int> inputWarriors = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

                Stack<int> warriors = new Stack<int>(inputWarriors);

                if (i % 3 == 0)
                {
                    int addplate = int.Parse(Console.ReadLine());

                    plates.Add(addplate);
                }

                while (warriors.Count > 0 && plates.Count > 0)
                {
                    int warrier = warriors.Pop();

                    if (warrier < plates[0])
                    {
                        plates[0] -= warrier;
                    }
                    else if(warrier == plates[0])
                    {
                        plates.RemoveAt(0);
                    }
                    else if (warrier > plates[0])
                    {
                        warrier -= plates[0];

                        plates.RemoveAt(0);

                        warriors.Push(warrier);
                    }
                }

                if(plates.Count == 0)
                {
                    Console.WriteLine($"The Trojans successfully destroyed the Spartan defense.");

                    Console.WriteLine($"Warriors left: {string.Join(", ", warriors)} ");

                    break;
                }
            }

            if (plates.Count > 0)
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");

                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
        }
    }
}
