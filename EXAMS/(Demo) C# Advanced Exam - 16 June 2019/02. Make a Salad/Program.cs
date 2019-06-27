using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> vegetables = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<int> calories = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> salads = new List<int>();


            while (vegetables.Count > 0 && calories.Count > 0)
            {
                int currentCalorie = calories[calories.Count - 1];

                while (currentCalorie > 0 && vegetables.Count > 0)
                {
                    string vegetable = vegetables[0];

                    vegetables.RemoveAt(0);

                    int calorieVegetable = CalculateCaloriesVegetable(vegetable);

                    currentCalorie -= calorieVegetable;
                }


                salads.Add(calories[calories.Count - 1]);

                calories.RemoveAt(calories.Count - 1);
            }



            if (salads.Count > 0)
            {
                Console.WriteLine(string.Join(' ', salads));
            }


            if (vegetables.Count > 0)
            {
                Console.WriteLine(string.Join(' ', vegetables));
            }
            else
            {
                for (int i = calories.Count - 1; i >= 0; i--)
                {
                    Console.Write($"{calories[i]} ");
                }
            }
        }

        public static int CalculateCaloriesVegetable(string vegetable)
        {
            int calorieVegetable = 0;

            if (vegetable == "tomato")
            {
                calorieVegetable = 80;
            }
            else if (vegetable == "carrot")
            {
                calorieVegetable = 136;
            }
            else if (vegetable == "lettuce")
            {
                calorieVegetable = 109;
            }
            else if (vegetable == "potato")
            {
                calorieVegetable = 215;
            }

            return calorieVegetable;
        }
    }
}

