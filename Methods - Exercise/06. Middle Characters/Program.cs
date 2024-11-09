namespace Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Get_Middle_Characters(input);
        }

        static void Get_Middle_Characters(string input)
        {
            int a = input.Length % 2;
            char middleCharacters = input[input.Length / 2];

            if (a == 0)
            {
                Console.Write($"{input[input.Length / 2 - 1]}" + $"{input[input.Length / 2]}");
            }
            else
            {
                Console.Write(middleCharacters);

            }
        }
    }
}