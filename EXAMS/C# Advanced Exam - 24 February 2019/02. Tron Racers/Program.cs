using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Tron_Racers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int firstPlayerRow = -1;

            int firstPlayerCol = -1;

            int secondPlayerRow = -1;

            int secondPlayerCol = -1;

            for (int row = 0; row < size; row++)
            {
                string inputRow = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = inputRow[col];

                    if (matrix[row, col] == 'f')
                    {
                        firstPlayerRow = row;
                        firstPlayerCol = col;
                    }
                    else if (matrix[row, col] == 's')
                    {
                        secondPlayerRow = row;
                        secondPlayerCol = col;
                    }
                }
            }

            while (true)
            {
                List<string> commands = Console.ReadLine().Split().ToList();

                string commandFirstPlayer = commands[0];
                string commandSecondPlayer = commands[1];

                List<int> dimensionsFirstPlayer = Move(firstPlayerRow, firstPlayerCol, size, commandFirstPlayer);
                firstPlayerRow = dimensionsFirstPlayer[0];
                firstPlayerCol = dimensionsFirstPlayer[1];

                if (matrix[firstPlayerRow, firstPlayerCol] == 's')
                {
                    matrix[firstPlayerRow, firstPlayerCol] = 'x';
                    break;
                }
                else if (matrix[firstPlayerRow, firstPlayerCol] == '*')
                {
                    matrix[firstPlayerRow, firstPlayerCol] = 'f';
                }

                List<int> dimensionsSecondPlayer = Move(secondPlayerRow, secondPlayerCol, size, commandSecondPlayer);
                secondPlayerRow = dimensionsSecondPlayer[0];
                secondPlayerCol = dimensionsSecondPlayer[1];

                if (matrix[secondPlayerRow, secondPlayerCol] == 'f')
                {
                    matrix[secondPlayerRow, secondPlayerCol] = 'x';
                    break;
                }
                else if (matrix[secondPlayerRow, secondPlayerCol] == '*')
                {
                    matrix[secondPlayerRow, secondPlayerCol] = 's';
                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write($"{(char)matrix[row, col]}");
                }

                Console.WriteLine();
            }
        }

        public static List<int> Move(int row, int col, int size, string command)
        {
            if (command == "up")
            {
                if (row == 0)
                {
                    row = size - 1;
                }
                else
                {
                    row--;
                }
            }
            else if (command == "down")
            {
                if (row == size - 1)
                {
                    row = 0;
                }
                else
                {
                    row++;
                }
            }
            else if (command == "left")
            {
                if (col == 0)
                {
                    col = size - 1;
                }
                else
                {
                    col--;
                }
            }
            else if (command == "right")
            {
                if (col == size - 1)
                {
                    col = 0;
                }
                else
                {
                    col++;
                }
            }

            List<int> dimensions = new List<int>() { row, col };

            return dimensions;
        }
    }
}
