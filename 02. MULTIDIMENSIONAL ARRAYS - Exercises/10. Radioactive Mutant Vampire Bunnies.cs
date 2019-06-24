using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dimensions = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            int numberRows = dimensions[0];
            int numberCols = dimensions[1];

            char[,] lair = new char[numberRows, numberCols];

            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < numberRows; row++)
            {
                string inputRow = Console.ReadLine();

                for (int col = 0; col < numberCols; col++)
                {
                    lair[row, col] = inputRow[col];

                    if (lair[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                        lair[playerRow, playerCol] = '.';
                    }
                }
            }

            bool won = false;

            bool died = false;

            string commands = Console.ReadLine();

            for (int i = 0; i < commands.Length; i++)
            {
                char currentCommand = commands[i];

                List<int> newDimensions = MovePlayer(currentCommand, playerRow, playerCol, lair);

                if (IsInBorder(newDimensions, numberRows, numberCols))
                {
                    playerRow = newDimensions[0];
                    playerCol = newDimensions[1];

                    if (lair[playerRow, playerCol] == '.')
                    {
                        lair[playerRow, playerCol] = 'P';
                    }
                    else if (lair[playerRow, playerCol] == 'B')
                    {
                        died = true;
                    }
                }
                else
                {
                    lair[playerRow, playerCol] = '.';

                    won = true;
                }

                lair = SpreadBunnies(lair);

                if (won)
                {
                    PrintMatrix(lair);

                    Console.WriteLine($"won: {playerRow} {playerCol}");

                    break;
                }

                if (died)
                {
                    PrintMatrix(lair);

                    Console.WriteLine($"dead: {playerRow} {playerCol}");

                    break;
                }

                if (lair[playerRow, playerCol] == 'B')
                {
                    PrintMatrix(lair);

                    Console.WriteLine($"dead: {playerRow} {playerCol}");

                    died = true;

                    break;
                }

                lair[playerRow, playerCol] = '.';
            }
        }

        public static char [,] SpreadBunnies(char[,] matrix)
        {
            char[,] lair = new char[matrix.GetLength(0), matrix.GetLength(1)];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    lair[row, col] = matrix[row, col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B' && lair[row,col] == 'B')
                    {
                        if (row > 0 && row < matrix.GetLength(0) - 1)
                        {
                            lair[row - 1, col] = 'B';

                            lair[row + 1, col] = 'B';
                        }
                        else if(row == 0 && matrix.GetLength(0) > 1)
                        {
                            lair[row + 1, col] = 'B';
                        }
                        else if(row == matrix.GetLength(0) - 1 && matrix.GetLength(0) > 1)
                        {
                            lair[row - 1, col] = 'B';
                        }


                        if (col > 0 && col < matrix.GetLength(1) - 1)
                        {
                            lair[row, col - 1] = 'B';
                            lair[row, col + 1] = 'B';
                        }
                        else if(col == 0 && matrix.GetLength(1) > 1)
                        {
                            lair[row, col + 1] = 'B';
                        }
                        else if(col == matrix.GetLength(1) - 1 && matrix.GetLength(1) > 1)
                        {
                            lair[row, col - 1] = 'B';
                        }
                    }
                }
            }

            return lair;
        }
    
        public static List<int> MovePlayer(char command, int row, int col, char[,] matrix)
        {
            if(command == 'U')
            {
                row--;
            }
            else if(command == 'D')
            {
                row++;
            }
            else if (command == 'L')
            {
                col--;
            }
            else if (command == 'R')
            {
                col++;
            }

            List<int> dimensions = new List<int>() { row, col };

            return dimensions;
        }

        public static bool IsInBorder(List<int> dimensions, int numberRows, int numberCols)
        {
            bool result = false;

            int row = dimensions[0];
            int col = dimensions[1];

            if (col >= 0 && col < numberCols && row >= 0 && row < numberRows)
            {
                result = true;
            }

            return result;
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }

                Console.WriteLine();
            }
        }
    }
}
