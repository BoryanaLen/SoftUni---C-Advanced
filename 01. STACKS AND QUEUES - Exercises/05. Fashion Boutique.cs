using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> stack = new Stack<int>(sequence);

            int capacity = int.Parse(Console.ReadLine());

            int currentSum = 0;

            int countRack = 1;

            for (int i = sequence.Count - 1; i >= 0; i--)
            {
                int currentPiece = sequence[i];

                if (capacity > (currentSum + currentPiece))
                {
                    currentSum += currentPiece;

                    stack.Pop();
                }
                else if(capacity == (currentSum + currentPiece))
                {
                    currentSum += currentPiece;

                    stack.Pop();

                    if (i > 0)
                    {
                        countRack++;

                        currentSum = 0;
                    }
                }
                else if (capacity < (currentSum + currentPiece))
                {
                    countRack++;

                    currentSum = currentPiece;

                    stack.Pop();
                }
            }

            Console.WriteLine(countRack);
        }
    }
}
