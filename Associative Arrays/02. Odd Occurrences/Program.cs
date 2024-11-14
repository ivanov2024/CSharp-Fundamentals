﻿namespace Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string,int> counts = new Dictionary<string,int>();

            foreach (string word in words)
            {
                string lowerWord = word.ToLower();
                if (counts.ContainsKey(lowerWord))
                {
                    counts[lowerWord]++;
                }
                else
                {
                    counts.Add(lowerWord, 1);
                }
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}