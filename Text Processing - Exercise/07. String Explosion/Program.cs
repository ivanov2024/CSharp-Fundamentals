﻿namespace String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";
            int strength = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    strength += int.Parse(input[i + 1].ToString());
                    result += input[i];
                }
                else if (strength == 0)
                {
                    result += input[i];
                }
                else
                {
                    strength--;
                }
            }

            Console.WriteLine(result);
        }
    }
}