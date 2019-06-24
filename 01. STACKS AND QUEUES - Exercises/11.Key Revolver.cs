using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());

            int gunBarrelSize = int.Parse(Console.ReadLine());

            List<int> inputBullets = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> bullets = new Stack<int>(inputBullets);

            List<int> inputLocks = Console.ReadLine().Split().Select(int.Parse).ToList();

            Queue<int> locks = new Queue<int>(inputLocks);

            int intelligence = int.Parse(Console.ReadLine());

            int currentCount = 0;

            int totalCount = 0;

            while (true)
            {
                if (locks.Count > 0 && bullets.Count > 0)
                {
                    int currentLock = locks.Peek();

                    int currentBullet = bullets.Pop();

                    if (currentBullet <= currentLock)
                    {
                        Console.WriteLine("Bang!");

                        locks.Dequeue();
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                    }

                    currentCount++;
                    totalCount++;

                    if (currentCount == gunBarrelSize && bullets.Count > 0)
                    {
                        Console.WriteLine("Reloading!");

                        currentCount = 0;
                    }
                }
                else
                {
                    break;
                }
            }
            
            if(locks.Count == 0)
            {
                int moneyEarned = intelligence - (totalCount * bulletPrice);

                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
            else if (bullets.Count == 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
