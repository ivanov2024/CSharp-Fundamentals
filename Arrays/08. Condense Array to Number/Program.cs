namespace Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[elements.Length - 1];

            while (elements.Length > 1)
            {

                for (int i = 0; i < elements.Length-1; i++)
                {
                    condensed[i] = elements[i] + elements[i + 1];

                    if (i == elements.Length - 2)
                    {
                        elements = condensed;
                        condensed = new int[elements.Length - 1];
                    }
                }
            }


            Console.WriteLine(elements[0]);
        }
    }
}