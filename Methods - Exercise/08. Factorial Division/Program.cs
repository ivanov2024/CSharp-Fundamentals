using System.Xml;

namespace Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            Output(n1, n2);
        }

        static void Output(double n1, double n2)
        {
            Console.WriteLine($"{(First_N_Calculation(n1) / Second_N_Calculation(n2)):f2}");
        }

        static double First_N_Calculation(double n1)
        {
            double sum = n1;
            for (double i = 1; i < n1; i++)
            {
                sum *= i;
            }

            return sum;
        }

        static double Second_N_Calculation(double n2)
        {
            double sum = n2;
            for (double i = 1; i < n2; i++)
            {
                sum *= i;
            }

            return sum;
        }
    }
}