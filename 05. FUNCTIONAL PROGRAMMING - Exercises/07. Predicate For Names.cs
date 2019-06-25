using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Predicate<string> isLessOrEqualLength = (x => x.Length <= nameLength);

            var sortedNames = names.Where(x => isLessOrEqualLength(x));

            Console.WriteLine(string.Join("\n", sortedNames));
        }
    }
}
