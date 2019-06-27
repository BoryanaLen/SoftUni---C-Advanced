using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Helen_s_Abduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            int numberRows = int.Parse(Console.ReadLine());

            char[][] field = new char[numberRows][];

            int parisRow = -1;

            int parisCol = -1;

            for (int row = 0; row < numberRows; row++)
            {
                string inputRow = Console.ReadLine();

                field[row] = new char[inputRow.Length]; 

                for (int col = 0; col < inputRow.Length; col++)
                {
                    field[row][col] = inputRow[col];

                    if(inputRow[col] == 'P')
                    {
                        parisRow = row;
                        parisCol = col;
                    }
                }
            }

            int numberCols = field[0].Count();

            while (true)
            {
                List<string> commandInfo = Console.ReadLine().Split().ToList();

                string command = commandInfo[0];

                int row = int.Parse(commandInfo[1]);

                int col = int.Parse(commandInfo[2]);

                if (row >= 0 && row < numberRows && col >= 0 && col < numberCols)
                {
                    if(field[row][col] == '-')
                    {
                        field[row][col] = 'S' ;
                    }
                }

                energy -= 1;

                field[parisRow][parisCol] = '-';

                if (command == "up")
                {
                    if (parisRow - 1 >= 0)
                    {
                        parisRow--;
                    }
                }
                else if(command == "down")
                {
                    if (parisRow + 1 < numberRows)
                    {
                        parisRow++;
                    }
                }
                else if(command == "left")
                {
                    if (parisCol - 1 >= 0)
                    {
                        parisCol--;
                    }
                }
                else if (command == "right")
                {
                    if (parisCol + 1 < numberCols)
                    {
                        parisCol++;
                    }
                }

                if(field[parisRow][parisCol] == 'H')
                {
                    Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
                    field[parisRow][parisCol] = '-';
                    break;
                }

                if (energy > 0)
                {
                    if (field[parisRow][parisCol] == 'S')
                    {
                        energy -= 2;

                        if (energy <= 0)
                        {
                            field[parisRow][parisCol] = 'X';

                            Console.WriteLine($"Paris died at {parisRow};{parisCol}.");

                            break;
                        }
                        else
                        {
                            field[parisRow][parisCol] = '-';
                        }
                    }
                }
                else
                {
                    field[parisRow][parisCol] = 'X';
                    Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
                    break;
                }
            }

            foreach(var item in field)
            {
                Console.WriteLine(string.Join("",item));
            }
        }
    }
}
