using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> leftSocks = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> rightSocks = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> pairs = new List<int>();

            while(leftSocks.Count > 0 && rightSocks.Count > 0)
            {
                int currentLeftSock = leftSocks[leftSocks.Count - 1];

                int currentRightSock = rightSocks[0];

                if (currentLeftSock > currentRightSock)
                {
                    pairs.Add(currentLeftSock + currentRightSock);

                    leftSocks.RemoveAt(leftSocks.Count - 1);

                    rightSocks.RemoveAt(0);
                }
                else if(currentLeftSock < currentRightSock)
                {
                    leftSocks.RemoveAt(leftSocks.Count - 1);
                }
                else if(currentLeftSock == currentRightSock)
                {
                    rightSocks.RemoveAt(0);

                    leftSocks[leftSocks.Count - 1]++;
                }
            }

            Console.WriteLine(pairs.Max());

            Console.WriteLine(string.Join(' ', pairs));
        }
    }
}
