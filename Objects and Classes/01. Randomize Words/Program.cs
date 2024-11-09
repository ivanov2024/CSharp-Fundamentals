namespace Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            // Welcome to SoftUni and have fun learning programming
            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                string value = input[i];
                int index = rnd.Next(0, input.Length);
                string rValue = input[index];

                input[i] = rValue;
                input[index] = value;
            }

            foreach (string s in input)
            {
                Console.WriteLine(s);
            }
        }
    }
}