using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRows = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numberRows; i++)
            {
                List<int> commandInfo = Console.ReadLine().Split().Select(int.Parse).ToList();

                int command = commandInfo[0];

                if (command == 1)
                {
                    stack.Push(commandInfo[1]);
                }
                else if (command == 2)
                {
                    if (stack.Count() > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (command == 3)
                {
                    if (stack.Count() > 0)
                    {
                        Console.WriteLine($"{stack.Max()}");
                    }                     
                }
                else if (command == 4)
                {
                    if (stack.Count() > 0)
                    {
                        Console.WriteLine($"{stack.Min()}");
                    }                     
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
