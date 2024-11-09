namespace Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char start2 = start;
            char end2 = end;
            Range(start,end, start2, end2);
        }

        static void Range(char start, char end, char start2, char end2)
        {
            if (end < start)
            {
              start2 = end;
               end2 = start;
            }

            for (int i = start2 + 1; i < end2; i++)
            {
                Console.Write((char)i + " ");
            }

        }
    }
}