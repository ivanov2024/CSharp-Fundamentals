namespace Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            int numbers2 = numbers.Count;
            for (int j = 0; j < numbers2/ 2; j++)
            {
                numbers[j] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }
               
            Console.WriteLine(string.Join(" ", numbers));
        }
    } 
}