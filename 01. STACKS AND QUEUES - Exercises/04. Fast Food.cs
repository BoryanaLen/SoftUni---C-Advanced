using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            Queue<int> orders = new Queue<int>(input);

            bool isFinished = true;

            Console.WriteLine($"{orders.Max()}");

            for (int i = 0; i < input.Count; i++)
            {
                if (quantity >= input[i])
                {
                    quantity -= input[i];

                    orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(' ',orders)}");
                    isFinished = false;
                    break;
                }
            }

            if(isFinished == true)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
