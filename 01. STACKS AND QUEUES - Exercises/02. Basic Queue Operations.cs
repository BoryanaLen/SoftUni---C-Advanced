using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parametes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numberToAdd = parametes[0];
            int numberToRemove = parametes[1];
            int numberElement = parametes[2];

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (numberToAdd > array.Count())
            {
                numberToAdd = array.Count();
            }

            Queue<int> queue = new Queue<int>(numberToAdd);

            for (int i = 0; i < numberToAdd; i++)
            {
                queue.Enqueue(array[i]);
            }

            if (numberToRemove > array.Count())
            {
                numberToRemove = array.Count();
            }

            for (int i = 0; i < numberToRemove; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(numberElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count() == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    int minNumber = queue.Min();
                    Console.WriteLine($"{minNumber}");
                }
            }
        }
    }
}
