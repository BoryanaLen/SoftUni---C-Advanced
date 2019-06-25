using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "end")
                {
                    break;
                }

                if(command == "add")
                {
                    numbers = numbers.Select(x => x += 1).ToList();
                }
                else if(command == "multiply")
                {
                    numbers = numbers.Select(x => x *= 2).ToList();
                }
                else if(command == "subtract")
                {
                    numbers = numbers.Select(x => x -= 1).ToList();
                }
                else if(command == "print")
                {
                    Console.WriteLine(string.Join(' ', numbers));
                }
            }
        }
    }
}
