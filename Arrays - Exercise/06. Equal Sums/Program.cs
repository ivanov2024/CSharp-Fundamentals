using System;

namespace Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int rightSum = 0;
                int leftSum = 0;
                index = -1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                for (int m = i - 1; m >= 0; m--)
                {
                    leftSum+= numbers[m];
                }

                if (rightSum == leftSum)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}