using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[size][];

            for (int row = 0; row < size; row++)
            {
                List<int> rowContent = Console.ReadLine().Split().Select(int.Parse).ToList();

                jaggedArray[row] = new int[rowContent.Count];

                for (int col = 0; col < rowContent.Count; col++)
                {
                    jaggedArray[row][col] = rowContent[col];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                List<string> commandInfo = input.Split().ToList();

                int row = int.Parse(commandInfo[1]);

                int col = int.Parse(commandInfo[2]);

                int value = int.Parse(commandInfo[3]);

                if(row >= jaggedArray.Count() || row < 0 || col < 0 || col >= jaggedArray[row].Count())
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if(commandInfo[0] == "Add")
                {
                    jaggedArray[row][col] += value;
                }
                else if(commandInfo[0] == "Subtract")
                {
                    jaggedArray[row][col] -= value;
                }
            }

            foreach(var item in jaggedArray)
            {
                Console.WriteLine(string.Join(' ', item));
            }
        }
    }
}
