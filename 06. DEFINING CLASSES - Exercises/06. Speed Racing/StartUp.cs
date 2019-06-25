using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberars; i++)
            {
                List<string> inputInfo = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string model = inputInfo[0];

                double fuelAmount = double.Parse(inputInfo[1]);

                double fuelConsumptionFor1km = double.Parse(inputInfo[2]);

                Car currentCar = new Car(model, fuelAmount, fuelConsumptionFor1km);
 
                cars.Add(currentCar);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    break;
                }

                List<string> inputInfo = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string model = inputInfo[1];

                double amountOfKm = double.Parse(inputInfo[2]);

                if (cars.Any(car => car.Model == model))
                {
                    for (int i = 0; i < cars.Count; i++)
                    {
                        if(cars[i].Model == model)
                        {
                            cars[i].Drive(amountOfKm);
                            break;
                        }
                    }
                }
            }

            foreach(var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
