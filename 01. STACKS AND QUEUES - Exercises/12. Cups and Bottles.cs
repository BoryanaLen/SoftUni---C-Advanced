using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputCups = Console.ReadLine().Split().Select(int.Parse).ToList();

            Queue<int> cups = new Queue<int>(inputCups);

            List<int> inputBottles = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> bottles = new Stack<int>(inputBottles);

            int wastedWater = 0;

            int currentCup = 0;

            while (true)
            {
                if (cups.Count > 0 && bottles.Count > 0)
                {
                    int nextCup = cups.Peek();

                    int currentBottle = bottles.Pop();

                    currentCup += currentBottle;

                    if (currentCup >= nextCup)
                    {
                        wastedWater += currentCup - nextCup;

                        cups.Dequeue();

                        currentCup = 0;
                    }
                }
                else
                {
                    break;
                }
            }

            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(' ', bottles)}");
            }

            if (cups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(' ', cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
