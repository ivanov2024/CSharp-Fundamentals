namespace Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Calculations(num1,num2,operation);
        }

        static void Calculations(int num1, int num2, char operation)
        {
            switch (operation)
            {
                case '/': Console.WriteLine(num1 / num2);break;
                case '*': Console.WriteLine(num1 * num2); break;
                case '+': Console.WriteLine(num1 + num2); break;
                case '-': Console.WriteLine(num1 - num2); break;
            }
        }
    }
}