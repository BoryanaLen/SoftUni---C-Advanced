using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Inferno_III
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> gems = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            HashSet<int> positionForExclusion = new HashSet<int>();

            List<int> currentList = new List<int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Forge")
                {
                    for (int i = 0; i < gems.Count; i++)
                    {
                        if (!positionForExclusion.Contains(i))
                        {
                            currentList.Add(gems[i]);
                        }
                    }

                    Console.WriteLine(string.Join(' ', currentList));

                    break;
                }

                List<string> inputInfo = input
                    .Split(';', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string command = inputInfo[0];

                string type = inputInfo[1];

                int perimeter = int.Parse(inputInfo[2]);

                List<int> currentPositionsForExclusion = new List<int>();

                if (type == "Sum Left")
                {
                    for (int i = 0; i < gems.Count; i++)
                    {
                        if(SumLeft(i,gems) == perimeter)
                        {
                            currentPositionsForExclusion.Add(i);
                        }
                    }
                }
                else if(type == "Sum Right")
                {
                    for (int i = 0; i < gems.Count; i++)
                    {
                        if (SumRight(i, gems) == perimeter)
                        {
                            currentPositionsForExclusion.Add(i);
                        }
                    }
                }
                else if(type == "Sum Left Right")
                {
                    for (int i = 0; i < gems.Count; i++)
                    {
                        if (SumLeftRight(i, gems) == perimeter)
                        {
                            currentPositionsForExclusion.Add(i);
                        }
                    }
                }

                if(command == "Exclude")
                {
                    for (int i = 0; i < currentPositionsForExclusion.Count; i++)
                    {
                        positionForExclusion.Add(currentPositionsForExclusion[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < currentPositionsForExclusion.Count; i++)
                    {
                        if (positionForExclusion.Contains(currentPositionsForExclusion[i]))
                        {
                            positionForExclusion.Remove(currentPositionsForExclusion[i]);
                        }
                    }
                }
            }
        }

        public static int SumLeft(int position, List<int> numbers)
        {
            int result = 0;

            if (position > 0 && position < numbers.Count -1)
            {
                result = numbers[position] + numbers[position - 1];
            }
            else
            {
                result = numbers[position];
            }

            return result;
        }

        public static int SumRight(int position, List<int> numbers)
        {
            int result = 0;

            if (position >= 0 && position < numbers.Count - 1)
            {
                result = numbers[position] + numbers[position + 1];
            }
            else
            {
                result = numbers[position];
            }

            return result;
        }

        public static int SumLeftRight(int position, List<int> numbers)
        {
            int result = 0;

            if (position > 0 && position < numbers.Count - 1)
            {
                result = numbers[position] + numbers[position - 1] + numbers[position + 1];
            }
            else if(position == 0 && numbers.Count > 1)
            {
                result = numbers[position] + numbers[position + 1];
            }
            else if(position == numbers.Count - 1 && numbers.Count > 1)
            {
                result = numbers[position] + numbers[position - 1];
            }

            return result;
        }
    }
}
