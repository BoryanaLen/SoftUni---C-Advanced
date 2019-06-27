using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Club_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCapacity = int.Parse(Console.ReadLine());

            List<string> inputRow = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Stack<char> halls = new Stack<char>();

            for (int i = 0; i < inputRow.Count; i++)
            {
                string currentSymbol = inputRow[i];

                char hall = ' ';

                if(char.TryParse(currentSymbol, out hall))
                {
                    if (char.IsLetter(hall))
                    {
                        halls.Push(hall);
                    }
                }
            }

            while (halls.Count > 0)
            {
                char currentHall = halls.Pop();

                List<int> currentReservationsList = new List<int>();

                int currentCapacity = maxCapacity;

                List<int> reservations = inputRow
                    .Take(inputRow.IndexOf(currentHall.ToString()))
                    .Where(x => char.IsDigit(x, 0))
                    .Select(int.Parse)
                    .ToList();

                if (reservations.Count <= 0)
                {
                    break;
                }

                while(reservations.Count > 0)
                {
                    int reservation = reservations[reservations.Count - 1];

                    if (currentCapacity - reservation >= 0)
                    {
                        currentReservationsList.Add(reservation);

                        currentCapacity -= reservation;

                        reservations.RemoveAt(reservations.Count - 1);

                        inputRow.RemoveAt(inputRow.LastIndexOf(reservation.ToString()));
                    }
                    else
                    {
                        Console.WriteLine($"{currentHall} -> {string.Join(", ", currentReservationsList)}");
                        break;
                    }
                }
            }
        }
    }
}
