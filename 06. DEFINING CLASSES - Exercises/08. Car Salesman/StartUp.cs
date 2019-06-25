using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberEngimes = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberEngimes; i++)
            {
                List<string> inputInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                //"{model} {power} {displacement} {efficiency}"

                string model = inputInfo[0];

                int power = int.Parse(inputInfo[1]);

                Engine currentEngine = new Engine(model, power);

                if(inputInfo.Count == 3)
                {
                    if(int.TryParse(inputInfo[2],out int result))
                    {
                        currentEngine.Displacement = inputInfo[2];
                    }
                    else
                    {
                        currentEngine.Efficiency = inputInfo[2];
                    }
                }
                else if(inputInfo.Count == 4)
                {
                    currentEngine.Displacement = inputInfo[2];
                    currentEngine.Efficiency = inputInfo[3];
                }

                engines.Add(currentEngine);
            }

            int numberCars = int.Parse(Console.ReadLine());

            for (int j = 0; j < numberCars; j++)
            {
                List<string> inputInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                //"{model} {engine} {weight} {color}" 

                string model = inputInfo[0];

                string engineModel = inputInfo[1];

                Engine currentEngine = engines.Where(x => x.Model == engineModel).FirstOrDefault();

                if (currentEngine != null)
                {
                    Car currentCar = new Car(model, currentEngine);

                    if (inputInfo.Count == 3)
                    {
                        if (int.TryParse(inputInfo[2], out int result))
                        {
                            currentCar.Weight = inputInfo[2];
                        }
                        else
                        {
                            currentCar.Color = inputInfo[2];
                        }
                    }
                    else if (inputInfo.Count == 4)
                    {
                        currentCar.Weight = inputInfo[2];
                        currentCar.Color = inputInfo[3];
                    }

                    cars.Add(currentCar);
                }
            }

            foreach(var car in cars)
            {
                Console.Write(car.ToString());
            }
        }
    }
}
