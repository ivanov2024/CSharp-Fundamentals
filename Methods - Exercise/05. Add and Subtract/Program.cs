namespace Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            FinalResult(num1,num2, num3);
        }

        private static void FinalResult(double num1, double num2, double num3)
        {
            Console.WriteLine(Add(num1,num2) - num3);
        }

        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

    }
}