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

            var boxes = new List<Box<double>>();

            for (int i = 0; i < numberLines; i++)
            {
                double input = double.Parse(Console.ReadLine());

                Box<double> currentBox = new Box<double>(input);

                boxes.Add(currentBox);
            }

            double value = double.Parse(Console.ReadLine());

            Box<double> boxToFind = new Box<double>(value);

            Console.WriteLine(CountComparedStrings(boxes, boxToFind));

        }

        public static void Swap<T> (List<T> list, int firstIndex, int secondIndex)
        {
            if (firstIndex >= 0 && firstIndex < list.Count && secondIndex >= 0 && secondIndex < list.Count)
            {
                var temp = list[firstIndex];
                list[firstIndex] = list[secondIndex];
                list[secondIndex] = temp;
            }
        }

        public static int CountComparedStrings<T>(List<T> list, T value) 
            where T : IComparable<T>
        {
            int result = 0;

            foreach(var item in list)
            {
                if (item.CompareTo(value) > 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
