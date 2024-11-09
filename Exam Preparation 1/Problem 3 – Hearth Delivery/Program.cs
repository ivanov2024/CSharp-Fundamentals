namespace Problem_3___Hearth_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();
            int cupidIndex = 0;
            int cupidFails = 0;

            while (command[0] != "Love!")
            {
                int length = int.Parse(command[1]);
                cupidIndex += length;

                if (cupidIndex >= neighborhood.Length)
                {
                    cupidIndex = 0;
                }
                neighborhood[cupidIndex] -= 2;
                if (neighborhood[cupidIndex] == 0)
                {
                    Console.WriteLine($"Place {cupidIndex} has Valentine's day.");
                }
                
                if (neighborhood[cupidIndex] < 0)
                {
                    Console.WriteLine($"Place {cupidIndex} already had Valentine's day.");
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"Cupid's last position was {cupidIndex}.");

            for (int i = 0; i < neighborhood.Length; i++)
            {
                if (neighborhood[i] > 0)
                {
                    cupidFails++;
                }
            }

            if (cupidFails != 0)
            {
                Console.WriteLine($"Cupid has failed {cupidFails} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}