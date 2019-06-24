using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPumps = int.Parse(Console.ReadLine());

            Queue<long> circle = new Queue<long>();

            for (int i = 0; i < countPumps; i++)
            {
                List<string> inputInfo = Console.ReadLine().Split().ToList();

                long amount = long.Parse(inputInfo[0]);

                long distance = long.Parse(inputInfo[1]);

                long difference = amount - distance;

                circle.Enqueue(difference);
            }

            for (int i = 0; i < countPumps; i++)
            {
                int count = 0;
                long rezerv = 0;

                if (circle.Peek() < 0)
                {
                    circle.Enqueue(circle.Dequeue());
                    continue;
                }

                foreach (var item in circle)
                {
                    rezerv += item;

                    if (rezerv >= 0)
                    {
                        count++;
                    }
                }

                if (count == countPumps)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    circle.Enqueue(circle.Dequeue());
                }
            }
        }
    }
}
