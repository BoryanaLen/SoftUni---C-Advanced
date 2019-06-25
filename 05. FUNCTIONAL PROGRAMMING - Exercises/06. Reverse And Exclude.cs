using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int number = int.Parse(Console.ReadLine());

            Predicate<int> notDivisible = (x => x % number != 0);

            var newNumbers = numbers.Where(x => notDivisible(x)).Reverse();

            Console.WriteLine(string.Join(' ', newNumbers));
        }
    }
}
