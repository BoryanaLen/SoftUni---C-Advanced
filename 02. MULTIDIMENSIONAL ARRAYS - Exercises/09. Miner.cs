using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] array = new char[size, size];

            List<string> commands = Console.ReadLine().Split().ToList();

            for (int row = 0; row < size; row++)
            {
                List<char> rowContent = Console.ReadLine().Split().Select(char.Parse).ToList();

                for (int col = 0; col < size; col++)
                {
                    array[row, col] = rowContent[col];
                }
            }

            int countCoal = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if(array[row,col] == 'c')
                    {
                        countCoal++;
                    }
                }
            }

            int startRow = -1;

            int startCol = -1;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (array[row, col] == 's')
                    {
                        startRow = row;

                        startCol = col;
                    }
                }
            }

            int countCollectedCoals = 0;

            for (int i = 0; i < commands.Count; i++)
            {
                string command = commands[i];

                if(command == "left")
                {
                    if (startCol - 1 >= 0)
                    {
                        startCol -= 1;
                    } 
                }
                else if(command == "right")
                {
                    if (startCol + 1 < size)
                    {
                        startCol += 1;
                    }
                }
                else if (command == "up")
                {
                    if (startRow - 1 >= 0)
                    {
                        startRow -= 1;
                    }
                }
                else if (command == "down")
                {
                    if (startRow + 1 < size)
                    {
                        startRow += 1;
                    }
                }

                if(array[startRow,startCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({startRow}, {startCol})");

                    break;
                }
                else if (array[startRow, startCol] == 'c')
                {
                    countCollectedCoals++;

                    array[startRow, startCol] = '*';

                    if(countCollectedCoals == countCoal)
                    {
                        Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");

                        break;
                    }
                }

                if (i == commands.Count - 1)
                {
                    Console.WriteLine($"{countCoal - countCollectedCoals} coals left. ({startRow}, {startCol})");
                }
            }
        }
    }
}
