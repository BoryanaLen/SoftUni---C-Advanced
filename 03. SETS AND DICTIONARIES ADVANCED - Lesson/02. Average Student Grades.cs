using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberLines; i++)
            {
                List<string> inputRow = Console.ReadLine().Split().ToList();

                string name = inputRow[0];

                double grade = double.Parse(inputRow[1]);

                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students.Add(name, new List<double>() { grade });
                }
            }

            foreach(var name in students)
            {
                Console.Write($"{name.Key} -> ");

                foreach(var grade in name.Value)
                {
                    Console.Write($"{grade:F2} ");
                }

                Console.Write($"(avg: {(name.Value.Average()):F2})");

                Console.WriteLine();
            }
        }
    }
}
