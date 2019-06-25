using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            var boxes = new List<Box<string>>();

            for (int i = 0; i < numberLines; i++)
            {
                string input = Console.ReadLine();

                Box<string> currentBox = new Box<string>(input);

                boxes.Add(currentBox);
            }

            List<int> swapInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int firstIndex = swapInfo[0];
            int secondIndex = swapInfo[1];

            Swap(boxes, firstIndex, secondIndex);

            foreach(var element in boxes)
            {
                Console.WriteLine(element.ToString());
            }
        }

        public static void Swap<T> (List<Box<T>> list, int firstIndex, int secondIndex)
        {
            if (firstIndex >= 0 && firstIndex < list.Count && secondIndex >= 0 && secondIndex < list.Count)
            {
                var temp = list[firstIndex];
                list[firstIndex] = list[secondIndex];
                list[secondIndex] = temp;
            }
        }
    }
}
