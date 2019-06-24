using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());

            int freeWindowtDuration = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            int countCarsPassed = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{countCarsPassed} total cars passed the crossroads.");
                    break;
                }

                if(input == "green")
                {
                    bool isCrash = false;

                    int timeOut = greenLightDuration;

                    while (timeOut > 0)
                    {
                        if (cars.Count > 0)
                        {
                            string carOut = cars.Dequeue();

                            if (timeOut >= carOut.Length)
                            {
                                timeOut -= carOut.Length;
                                countCarsPassed++;
                            }
                            else
                            {
                                if ((carOut.Length - timeOut) <= freeWindowtDuration)
                                {
                                    timeOut -= carOut.Length;
                                    countCarsPassed++;
                                }
                                else
                                {
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{carOut} was hit at {carOut[freeWindowtDuration+timeOut]}.");
                                    isCrash = true;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (isCrash == true)
                    {
                        break;
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
            }
        }
    }
}
