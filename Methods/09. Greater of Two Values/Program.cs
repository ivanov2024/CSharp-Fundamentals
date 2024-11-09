using System.Diagnostics.CodeAnalysis;

namespace Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string type = Console.ReadLine();
            Result(type);
        }

        static void Result(string type)
        {
            switch (type)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetIntMax(num1, num2));
                    break;
                case "char":
                    char char1 = char.Parse(Console.ReadLine());
                    char char2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetCharMax(char1, char2));
                    break;
                case "string":
                    string string1 = Console.ReadLine();
                    string string2 = Console.ReadLine();
                    Console.WriteLine(GetStringMax(string1, string2));
                    break;
            }

        }

        static int GetIntMax(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }

        static char GetCharMax(char char1, char char2)
        {
            if (char1 > char2)
            {
                return char1;
            }
            else
            {
                return char2;
            }
        }

        static string GetStringMax(string string1, string string2)
        {
            int biggestString = string1.CompareTo(string2);

            if (biggestString > 0)
            {
                return string1;
            }
            else
            {
                return string2;
            }
        }
    }
}