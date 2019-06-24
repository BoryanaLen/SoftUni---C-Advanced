using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string inputRow = Console.ReadLine();

                if(inputRow == "end of contests")
                {
                    break;
                }

                List<string> inputInfo = inputRow.Split(':').ToList();

                string contest = inputInfo[0];

                string password = inputInfo[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, password);
                }
            }

            while (true)
            {
                string inputRow = Console.ReadLine();

                if (inputRow == "end of submissions")
                {
                    break;
                }

                List<string> inputInfo = inputRow.Split("=>").ToList();

                string contest = inputInfo[0];

                string password = inputInfo[1];

                string name = inputInfo[2];

                int points = int.Parse(inputInfo[3]);

                if (contests.ContainsKey(contest))
                {
                    if(contests[contest] == password)
                    {
                        if (users.ContainsKey(name))
                        {
                            if (users[name].ContainsKey(contest))
                            {
                                if(users[name][contest] < points)
                                {
                                    users[name][contest] = points;
                                }
                            }
                            else
                            {
                                users[name].Add(contest, points);
                            }
                        }
                        else
                        {
                            Dictionary<string, int> current = new Dictionary<string, int>();

                            current.Add(contest, points);

                            users.Add(name, current);
                        }
                    }
                }
            }

            var bestUser = users.OrderByDescending(x => x.Value.Sum(a => a.Value));

            string nameBestUser = string.Empty;

            foreach(var item in bestUser)
            {
                nameBestUser = item.Key;

                Console.WriteLine($"Best candidate is {item.Key} with total {item.Value.Sum(a => a.Value)} points.");
                break;
            }

            Console.WriteLine("Ranking:");

            var sortedUsers = users.OrderBy(x => x.Key);

            foreach(var user in sortedUsers)
            {
                Console.WriteLine(user.Key);

                var sortedContests = user.Value.OrderByDescending(x => x.Value);

                foreach(var element in sortedContests)
                {
                    Console.WriteLine($"#  {element.Key} -> {element.Value}");
                }
            }
        }
    }
}
