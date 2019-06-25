using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bounds = Console.ReadLine().Split().Select(int.Parse).ToList();

            int loweBound = bounds[0];

            int upperBound = bounds[1];

            string command = Console.ReadLine();

            List<int> numbers = new List<int>();

            for (int i = loweBound; i <= upperBound; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> isEven = (x => x % 2 == 0);

            Predicate<int> isOdd = (x => x % 2 != 0);

            if(command == "even")
            {
                var evenNumbers = numbers.Where(x => isEven(x)) ;

                Console.WriteLine(string.Join(' ', evenNumbers));
            }
            else if(command == "odd")
            {
                var oddNumbers = numbers.Where(x => isOdd(x));

                Console.WriteLine(string.Join(' ', oddNumbers));
            }
        }
    }
}
