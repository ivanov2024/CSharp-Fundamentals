﻿namespace Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                bool topNumber = true;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] >= array[j])
                    {
                        topNumber= false;
                        break;
                    }
                }

                if (topNumber)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
   
    
