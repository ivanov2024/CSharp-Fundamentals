﻿namespace Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2==0)
                {
                    evenSum += numbers[i];
                }
                else
                {
                    oddSum+= numbers[i];
                }
            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}