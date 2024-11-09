namespace Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool flag = true;
            string[] array1 = new string[n];
            string[] array2 = new string[n];

            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                string[] numbersAsArray = numbers.Split();
                if (flag)
                {
                    array1[i] = numbersAsArray[0];
                   array2[i] = numbersAsArray[1];
                }
                else
                {
                    array1[i] = numbersAsArray[1];
                    array2[i] = numbersAsArray[0];
                }

                flag = !flag;
            }

            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ", array2));
        }
    }
}