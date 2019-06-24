using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            while (true)
            {
                string inputRow = Console.ReadLine();

                if(inputRow == "END")
                {
                    break;
                }

                List<string> input = inputRow
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string command = input[0];

                string carNumber = input[1];

                if(command == "IN")
                {
                    cars.Add(carNumber);
                }
                else if(command == "OUT")
                {
                    cars.Remove(carNumber);
                }
            }


            if(cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }

            else
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }           
        }
    }
}
