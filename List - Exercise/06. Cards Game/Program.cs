using System.Collections.Generic;

namespace Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> deck2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (deck1.Count > 0 && deck2.Count > 0)
            {
                int p1card = deck1[0];
                int p2card = deck2[0];

                if (p1card > p2card)
                {
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                    deck1.Add(p2card);
                    deck1.Add(p1card);
                }
                else if (p2card > p1card)
                {
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                    deck2.Add(p1card);
                    deck2.Add(p2card);
                }
                else
                {
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                }
            }

            if (deck1.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {Sum(deck1)}");
            }
            else if (deck2.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {Sum(deck2)}");
            }
        }

        private static int Sum(List<int> list)
        {
            int sum = 0;
            foreach (int item in list)
            {
                sum += item;
            }

            return sum;
        }
    }
}
