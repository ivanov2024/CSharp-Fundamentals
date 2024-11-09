namespace Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string something = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(something, repeat));
        }

        static string RepeatString(string something, int repeat)
        {
            string result = "";

            for (int i = 0; i < repeat; i++)
            {
                result += something;
            }

            return result;
        }
    }
}