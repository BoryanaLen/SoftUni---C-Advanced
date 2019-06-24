using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> inputList = Console.ReadLine().ToList();

            inputList.Sort();

            HashSet<char> symbols = new HashSet<char>();

            foreach(var element in inputList)
            {
                symbols.Add(element);
            }

            foreach(var item in symbols)
            {
                Console.WriteLine($"{item}: {inputList.Count(x => x == item)} time/s");
            }

        }
    }
}
