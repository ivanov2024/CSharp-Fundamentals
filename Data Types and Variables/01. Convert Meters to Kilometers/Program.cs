﻿namespace Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{(meters / 1000):f2}");
        }
    }
}