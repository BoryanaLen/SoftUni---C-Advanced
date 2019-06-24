using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            HashSet<string> nonRepeatingCompounds = new HashSet<string>();

            for (int i = 0; i < numberLines; i++)
            {
                List<string> inputRow = Console.ReadLine()
                    .Split()
                    .ToList();

                for (int a = 0; a < inputRow.Count; a++)
                {
                    nonRepeatingCompounds.Add(inputRow[a]);
                }
            }

            List<string> nonRepeatingCompoundsList = nonRepeatingCompounds.ToList();

            nonRepeatingCompoundsList.Sort();

            Console.WriteLine(string.Join(' ', nonRepeatingCompoundsList));
        }
    }
}
