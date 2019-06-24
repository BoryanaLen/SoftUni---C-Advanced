using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i < numberLines; i++)
            {
                int number = int.Parse(Console.ReadLine());

                numbers.Add(number);
            }

            foreach(var number in numbers)
            {
                int count = numbers.Count(x => x == number);

                if (count % 2 == 0)
                {
                    Console.WriteLine(number);
                    break;
                }
            }
        }
    }
}
