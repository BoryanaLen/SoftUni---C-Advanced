using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            while (true)
            {
                string command = Console.ReadLine();

                if(command.ToLower() == "end")
                {
                    Console.WriteLine($"Sum: {stack.Sum()}");
                    break;
                }

                List<string> commandInfo = command.Split().ToList();

                if (commandInfo[0].ToLower() == "add")
                {
                    int firstNumber = int.Parse(commandInfo[1]);
                    int secondNumber = int.Parse(commandInfo[2]);

                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (commandInfo[0].ToLower() == "remove")
                {
                    int count = int.Parse(commandInfo[1]);

                    if (count > stack.Count)
                    {
                        continue;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        stack.Pop();
                    }
                }
            }
        }
    }
}
