﻿namespace Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int litters = int.Parse(Console.ReadLine());
                sum += litters;

                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= litters;
                }
            }

            Console.WriteLine(sum);
        }
    }
}