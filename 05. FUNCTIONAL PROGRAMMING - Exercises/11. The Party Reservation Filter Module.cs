using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> invitations = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            string perimeter = string.Empty;

            Predicate<string> isStartingWith = name => name.IndexOf(perimeter) == 0;

            Predicate<string> isEndingWith = name => name.IndexOf(perimeter) == name.Length - perimeter.Length;

            Predicate<string> isContainig = name => name.IndexOf(perimeter) >= 0;

            Predicate<string> isSameLength = name => name.Length == int.Parse(perimeter);

            List<string> additinalList = new List<string>();

            List<string> finalList = new List<string>(invitations);

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Print")
                {
                    invitations = invitations.Where(x => finalList.Contains(x)).ToList();

                    Console.WriteLine(string.Join(' ', invitations));

                    break;
                }

                List<string> inputInfo = input
                    .Split(';', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string command = inputInfo[0];

                string type = inputInfo[1];

                perimeter = inputInfo[2];

                if (type == "Starts with")
                {
                    additinalList = invitations.Where(x => isStartingWith(x) == true).ToList();
                }
                else if(type == "Ends with")
                {
                    additinalList = invitations.Where(x => isEndingWith(x) == true).ToList();
                }
                else if (type == "Length")
                {
                    additinalList = invitations.Where(x => isSameLength(x) == true).ToList();
                }
                else if (type == "Contains")
                {
                    additinalList = invitations.Where(x => isContainig(x) == true).ToList();
                }

                if (command == "Add filter")
                {
                    foreach(string name in additinalList)
                    {
                        finalList.Remove(name);
                    }
                }
                else if(command == "Remove filter")
                {
                    foreach (string name in additinalList)
                    {
                        finalList.Add(name);
                    }
                }
            }
        }
    }
}
