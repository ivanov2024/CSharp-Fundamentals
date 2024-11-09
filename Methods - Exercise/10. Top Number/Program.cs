using System.Diagnostics.CodeAnalysis;

namespace Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Output(n);
        }

        static void Output(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (Devisible_Check(i) && Odd_Digit_Check(i))
                {
                    Console.WriteLine(i);
                }
            }
        }


        static bool Devisible_Check(int i)
        {
            int sumOfDigits = 0;
            while (i > 0)
            {
                sumOfDigits += i % 10;
                i /= 10;
            }

            if (sumOfDigits%8==0)
            {
                return true;
            }

            return false;
        }
        static bool Odd_Digit_Check(int i)
        {
            while (i > 0)
            {
                int digit = i % 10;
                i /= 10;

                if (digit%2!=0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}