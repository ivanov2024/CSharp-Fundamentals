using System.Diagnostics.CodeAnalysis;

namespace Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            
            int index = 0;
            int bestIndex = 0;
            int bestCount = 0;
            int bestSum = 0;
            int bestStartIndex = int.MaxValue;
            string[] bestSequence = Array.Empty<string>();

            while (input != "Clone them!")
            {
                index += 1;
                int count = 0;
                int sum = 0;

                string[] sequence = input.Split("!", StringSplitOptions.RemoveEmptyEntries);

                for (int i = sequenceLength - 1; i >= 0; i--)
                {
                    if (sequence[i] == "1")
                    {
                        sum++;
                        count++;

                        if (bestCount < count || bestStartIndex > i || bestSum < sum)
                        {
                            bestIndex = index;
                            bestCount = count;
                            bestSum = sum;
                            bestStartIndex = i;
                            bestSequence = sequence;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}