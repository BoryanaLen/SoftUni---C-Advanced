using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            Queue<string> cars = new Queue<string>(input);

            Stack<string> servicesCars = new Stack<string>(input.Count);

            while (true)
            {
                string inputCommand= Console.ReadLine();

                List<string> commandInfo = inputCommand.Split('-').ToList();

                string command = commandInfo[0];

                if(command == "End")
                {
                    break;
                }
                else if(command == "Service")
                {
                    if (cars.Count > 0)
                    {
                        string vehicle = cars.Dequeue();

                        Console.WriteLine($"Vehicle {vehicle} got served.");

                        servicesCars.Push(vehicle);
                    }
                }
                else if (command == "CarInfo")
                {
                    string vehicle = commandInfo[1];

                    if (cars.Contains(vehicle))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else if (servicesCars.Contains(vehicle))
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (command == "History")
                {
                    Console.WriteLine(string.Join(", ", servicesCars));
                }
            }

            if (cars.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", cars)}");
            }

            if(servicesCars.Count > 0)
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", servicesCars)}");
            }
        }
    }
}
