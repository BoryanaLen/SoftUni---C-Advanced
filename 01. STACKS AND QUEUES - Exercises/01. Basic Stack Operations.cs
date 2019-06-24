using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parametes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numberToPush = parametes[0];
            int numberToPop = parametes[1];
            int numberElement = parametes[2];

            int [] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (numberToPush > array.Count())
            {
                numberToPush = array.Count();
            }

            Stack<int> stack = new Stack<int>(numberToPush);

            for (int i = 0; i < numberToPush; i++)
            {
                stack.Push(array[i]);
            }

            if(numberToPop > array.Count())
            {
                numberToPop = array.Count();
            }

            for (int i = 0; i < numberToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(numberElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                if(stack.Count() == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    int minNumber = stack.Min();
                    Console.WriteLine($"{minNumber}");
                }
            }
        }
    }
}
