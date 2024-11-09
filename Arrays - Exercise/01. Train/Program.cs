namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] people = new int[n];

            for (int i = 0; i < n; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                sum += people[i];
            }


            for (int i = 0; i < people.Length; i++)
            {
                Console.Write(people[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}