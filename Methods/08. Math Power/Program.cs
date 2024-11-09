namespace Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double powBase = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(powBase, power));
        }

        static double MathPower(double powBase, double power)
        {
            double sum = Math.Pow(powBase, power);
            return sum;
        }
    }
}