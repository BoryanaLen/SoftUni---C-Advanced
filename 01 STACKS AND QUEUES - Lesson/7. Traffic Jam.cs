using System;
using System.Collections.Generic;

namespace _7._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCarsGreenLight = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            int totalCars = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "end")
                {
                    Console.WriteLine($"{totalCars} cars passed the crossroads.");

                    break;
                }

                if(command == "green")
                {
                    if (numberCarsGreenLight > cars.Count)
                    {
                        numberCarsGreenLight = cars.Count;
                    }

                    for (int i = 0; i < numberCarsGreenLight; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        totalCars++;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }
        }
    }
}
