namespace Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string argument1 = input[0];
            string argument2 = input[1];

            int maxLength = Math.Max(argument1.Length, argument2.Length);
            int totalSum = 0;

            for (int i = 0; i < maxLength; i++)
            {
                if (i < argument1.Length && i < argument2.Length)
                {
                    totalSum += argument1[i] * argument2[i]; 
                }
                else if (i >= argument1.Length)
                {
                        totalSum += argument2[i];
                }
                else
                {
                        totalSum += argument1[i];
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}