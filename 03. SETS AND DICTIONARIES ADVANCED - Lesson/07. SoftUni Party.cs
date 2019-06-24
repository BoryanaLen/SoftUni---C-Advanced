using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();

            HashSet<string> regilarGuests = new HashSet<string>();


            while (true)
            {
                string input = Console.ReadLine();

                if(input == "PARTY")
                {
                    break;
                }

                if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regilarGuests.Add(input);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                if (char.IsDigit(input[0]))
                {
                    if (vipGuests.Contains(input))
                    {
                        vipGuests.Remove(input);
                    }
                }
                else
                {
                    if (regilarGuests.Contains(input))
                    {
                        regilarGuests.Remove(input);
                    }
                }
            }

            Console.WriteLine($"{vipGuests.Count + regilarGuests.Count}");

            foreach(var guest in vipGuests)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regilarGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
