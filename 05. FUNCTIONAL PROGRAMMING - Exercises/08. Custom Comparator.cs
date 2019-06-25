using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            Predicate<int> isEven = (x => x % 2 == 0);

            var sortedNumbers = numbers.OrderByDescending(x => isEven(x)).ThenBy(x => x);

            Console.WriteLine(string.Join(' ', sortedNumbers));
        }
    }
}
