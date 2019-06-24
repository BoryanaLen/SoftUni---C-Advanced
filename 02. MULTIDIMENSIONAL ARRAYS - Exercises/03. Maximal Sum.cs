using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dimensions = Console.ReadLine().Split().Select(int.Parse).ToList();

            int countRows = dimensions[0];

            int countCol = dimensions[1];

            int[][] array = new int[countRows][];

            for (int row = 0; row < countRows; row++)
            {
                List<int> rowContent = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                array[row] = new int[countCol];

                for (int col = 0; col < countCol; col++)
                {
                    array[row] [col] = rowContent[col];
                }
            }

            int sum = int.MinValue;

            int[][] maxArray = new int[3][];

            maxArray[0] = new int[3];

            maxArray[1] = new int[3];

            maxArray[2] = new int[3];

            for (int row = 0; row < countRows - 2; row++)
            {
                for (int col = 0; col < countCol - 2; col++)
                {
                    int currentSum = array[row] [col] + array[row] [col + 1] + array[row] [col + 2] +
                        array[row + 1] [col] + array[row + 1] [col + 1] + array[row + 1] [col + 2] +
                        array[row + 2] [col] + array[row + 2][col + 1] + array[row + 2] [col + 2];

                    if (currentSum > sum)
                    {
                        sum = currentSum;

                        maxArray[0] = array[row].Skip(col).Take(3).ToArray();

                        maxArray[1] = array[row + 1].Skip(col).Take(3).ToArray();

                        maxArray[2] = array[row + 2].Skip(col).Take(3).ToArray();
                    }
                }
            }

            Console.WriteLine($"Sum = {sum}");

            foreach(var item in maxArray)
            {
                Console.WriteLine(string.Join(' ', item));
            }
        }
    }
}


