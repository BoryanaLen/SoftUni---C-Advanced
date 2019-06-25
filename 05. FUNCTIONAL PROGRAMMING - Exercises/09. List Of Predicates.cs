using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endRange = int.Parse(Console.ReadLine());

            HashSet<int> dividers = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToHashSet();

            Func<int, HashSet<int>, bool> isNumberDivisible = IsDivisible;

            for (int i = 1; i <= endRange; i++)
            {
                if(isNumberDivisible(i, dividers))
                {
                    Console.Write($"{i} ");
                }
            }
        }

        public static bool IsDivisible (int number, HashSet<int> dividers)
        {
            bool result = false;

            int count = 0;

            foreach(int num in dividers)
            {
                if (number % num == 0)
                {
                    count++;
                }
            }

            if(count == dividers.Count)
            {
                result = true;
            }

            return result;
        }
    }
}
