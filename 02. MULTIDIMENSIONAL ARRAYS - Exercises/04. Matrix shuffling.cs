using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Matrix_shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dimensions = Console.ReadLine().Split().Select(int.Parse).ToList();

            int numberRols = dimensions[0];

            int numberCols = dimensions[1];

            string[,] array = new string[numberRols, numberCols];

            for (int row = 0; row < numberRols; row++)
            {
                List<string> symbols = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int col = 0; col < numberCols; col++)
                {
                    array[row, col] = symbols[col];
                }
            }


            while (true)
            {
                string command = Console.ReadLine();

                if(command == "END")
                {
                    break;
                }

                List<string> commandInfo =command.Split().ToList();

                if (commandInfo.Count != 5 || commandInfo[0]!= "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    int rowFirst = int.Parse(commandInfo[1]);

                    int colFirst = int.Parse(commandInfo[2]);

                    int rowSecond = int.Parse(commandInfo[3]);

                    int colSecond = int.Parse(commandInfo[4]);

                    if (rowFirst < 0 || rowFirst > numberRols - 1 || rowSecond < 0 || rowSecond > numberRols - 1 ||
                        colFirst < 0 || colFirst > numberCols - 1 || colSecond < 0 || colSecond > numberCols - 1)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    else
                    {
                        string cell = array[rowFirst, colFirst];

                        array[rowFirst, colFirst] = array[rowSecond, colSecond];

                        array[rowSecond, colSecond] = cell;


                        for (int row = 0; row < numberRols; row++)
                        {
                            for (int col = 0; col < numberCols; col++)
                            {
                                Console.Write($"{array[row, col]} ");
                            }

                            Console.WriteLine();
                        }

                    }
                }
            }
        }
    }
}
