using System;
using System.Collections.Generic;
using System.Linq;

namespace ExcelFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRows = int.Parse(Console.ReadLine());

            List<string> header = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[][] matrix = new string[numberRows - 1][];

            for (int row = 0; row < numberRows - 1; row++)
            {
                string[] inputRow = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                matrix[row] = inputRow;
            }

            List<string> commandInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = commandInfo[0];
            string headerValue = commandInfo[1];
            bool isFiltered = false;
            int index = header.IndexOf(headerValue);

            if (command == "hide")
            {
                header.Remove(headerValue);

                for (int row = 0; row < numberRows - 1; row++)
                {
                    List<string> current = matrix[row].ToList();
                    current.RemoveAt(index);
                    matrix[row] = current.ToArray();
                }
            }
            else if (command == "sort")
            {
                matrix = matrix
                    .OrderBy(x => x[index])
                    .ToArray();
            }
            else if (command == "filter")
            {
                string value = commandInfo[2];

                Console.WriteLine(string.Join(" | ", header));

                for (int row = 0; row < numberRows - 1; row++)
                {
                    if (matrix[row][index] == value)
                    {
                        Console.WriteLine(string.Join(" | ", matrix[row]));
                    }
                }

                isFiltered = true;
            }

            if (isFiltered == false)
            {
                Console.WriteLine(string.Join(" | ", header));

                for (int row = 0; row < numberRows - 1; row++)
                {
                    Console.WriteLine(string.Join(" | ", matrix[row]));
                }
            }
        }
    }
}
