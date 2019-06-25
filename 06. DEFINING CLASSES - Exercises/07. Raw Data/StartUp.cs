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

                //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age}
                //{ tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"

                string model = inputInfo[0];

                Car currentCar = new Car(model);

                currentCar.Engine.Speed = int.Parse(inputInfo[1]);

                currentCar.Engine.Power = int.Parse(inputInfo[2]);

                currentCar.Cargo.Weight = int.Parse(inputInfo[3]);

                currentCar.Cargo.Type = inputInfo[4];

                for (int j = 5; j < inputInfo.Count-1; j+=2)
                {
                    double pressure = double.Parse(inputInfo[j]);

                    int age = int.Parse(inputInfo[j + 1]);

                    currentCar.Tires.Add(new Tire(pressure, age));
                }

                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            if(command == "fragile")
            {
                var sortedCars = cars
                    .Where(x => x.Cargo.Type == "fragile")
                    .Where(y => y.Tires.Any(z => z.Pressure < 1));

                foreach(var car in sortedCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if(command == "flamable")
            {
                var sortedCars = cars
                   .Where(x => x.Cargo.Type == "flamable")
                   .Where(y => y.Engine.Power > 250);

                foreach (var car in sortedCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
