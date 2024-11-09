using static System.Collections.Specialized.BitVector32;

namespace Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().
             Split('|').ToList();
           
            list.Reverse();

            List<int> combinedArray = new List<int>();

            foreach (string arrayString in list)
            {
                int[] numbers = arrayString.Trim()
                    .Split(' ')
                    .Where(i => !string.IsNullOrWhiteSpace(i))
                    .Select(i => int.Parse(i))
                    .ToArray();

                combinedArray.AddRange(numbers);
            }

            Console.WriteLine(string.Join(" ", combinedArray));
        }
    }
}