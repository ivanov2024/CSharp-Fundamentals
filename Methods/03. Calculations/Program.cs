using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string function = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = 0;
            Calculations(function,num1,num2,sum);
        }

        static void Calculations(string function, int num1, int num2, int sum)
        {
            switch (function)
            {
                case "add":
                    sum = num1+ num2; Console.WriteLine(sum); break;
                case "multiply":
                    sum = num1 * num2; Console.WriteLine(sum); break;
                case "subtract":
                    sum = num1 - num2; Console.WriteLine(sum); break;
                case "divide":
                    sum = num1 / num2; Console.WriteLine(sum); break;
                default:
                    break;
            }
        }
    }
}