using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberLines = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int firstSetLines = numberLines[0];

            int secondSetLines = numberLines[1];

            HashSet<int> firstSet = new HashSet<int>(firstSetLines);

            HashSet<int> secondSet = new HashSet<int>(secondSetLines);

            for (int i = 0; i < firstSetLines + secondSetLines; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                if (i < firstSetLines)
                {
                    firstSet.Add(inputNumber);
                }
                else
                {
                    secondSet.Add(inputNumber);
                }
            }

            foreach(var number in firstSet)
            { 
                if (secondSet.Contains(number))
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
