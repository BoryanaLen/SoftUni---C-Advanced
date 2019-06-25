using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tiresList = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            while (true)
            {
                string inputTires = Console.ReadLine();

                if(inputTires == "No more tires")
                {
                    break;
                }

                List<string> inputInfo = inputTires.Split().ToList();
                 
                Tire[] currentArray = new Tire[inputInfo.Count() / 2];

                int position = 0;

                for (int i = 0; i < inputInfo.Count(); i = i + 2)
                {
                    int year = int.Parse(inputInfo[i]);

                    double pressure = double.Parse(inputInfo[i + 1]);

                    currentArray[position] = (new Tire(year, pressure));

                    position++;                 
                }

                tiresList.Add(currentArray);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Engines done")
                {
                    break;
                }

                List<string> inputInfo = input.Split().ToList();

                int horsePower = int.Parse(inputInfo[0]);

                double cubicCapacity = double.Parse(inputInfo[1]);

                engines.Add(new Engine(horsePower, cubicCapacity));
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Show special")
                {
                    break;
                }

                List<string> inputInfo = input.Split().ToList();

                //{make} {model} {year} {fuelQuantity} {fuelConsumption} {engineIndex} {tiresIndex}

                string make = inputInfo[0];

                string model = inputInfo[1];

                int year = int.Parse(inputInfo[2]);

                double fuelQuantity = double.Parse(inputInfo[3]);

                double fuelConsumption = double.Parse(inputInfo[4]);

                int engineIndex = int.Parse(inputInfo[5]);

                int tiresIndex = int.Parse(inputInfo[6]);

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption,
                    engines[engineIndex], tiresList[tiresIndex]));
            }

            for (int i = 0; i < cars.Count; i++)
            {
                double sumPressures = cars[i].Tires.Sum(x => x.Pressure);

                int year = cars[i].Year;

                int horsePower = cars[i].Engine.HorsePower;

                if (year >= 2017 && horsePower > 330 && sumPressures >= 9 && sumPressures <= 10)
                {
                    cars[i].Drive(20);

                    Console.WriteLine(cars[i].WhoAmI());
                }
            }
        }
    }
}
