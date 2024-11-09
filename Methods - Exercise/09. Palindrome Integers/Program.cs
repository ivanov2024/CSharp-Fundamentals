using System.Runtime.InteropServices;
using System.Xml;

namespace Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Output(input);
        }

        static void Output(string input)
        {
            {
                while (input != "END")
                {
                    bool palindrom = false;
                    char[] reversedInput = input.ToCharArray();
                    Array.Reverse(reversedInput);
                    int comparison = input.CompareTo(new string(reversedInput));
                    if (comparison == 0)
                    {
                        palindrom = true;
                        Console.WriteLine(palindrom);
                    }
                    else
                    {
                        Console.WriteLine(palindrom);
                    }
                    input = Console.ReadLine();
                }
            }

        }
    }
}