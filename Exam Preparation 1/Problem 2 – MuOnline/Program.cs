using System.Threading;

namespace Problem_2___MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dungeon = Console.ReadLine().Split('|');
            int health = 100;
            int bitcoins = 0;
            int bestRoom = 0;

            for (int i = 0; i < dungeon.Length; i++)
            {
                bestRoom++;
                string[] room = dungeon[i].Split();
                string encounter = room[0];
                int number = int.Parse(room[1]);

                if (encounter == "potion")
                {
                    if (number + health > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                        Console.WriteLine($"Current health: {health} hp.");
                        continue;
                    }
                    else
                    {
                        
                        Console.WriteLine($"You healed for {number} hp.");
                        health += number;
                        Console.WriteLine($"Current health: {health} hp.");
                        continue;
                    }
                }

                if (encounter == "chest")
                {
                    Console.WriteLine($"You found {number} bitcoins.");
                    bitcoins += number;
                    continue;
                }

                health -= number;
                if (health > 0)
                {
                    Console.WriteLine($"You slayed {encounter}.");
                }
                else
                {
                    Console.WriteLine($"You died! Killed by {encounter}.");
                    Console.WriteLine($"Best room: {bestRoom}");
                    break;
                }
            }

            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}