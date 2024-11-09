namespace Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine()
                .Split().Select(int.Parse).ToList();

            List<int> list2 = Console.ReadLine()
                .Split().Select(int.Parse).ToList();

            int maxLenght = Math.Max(list1.Count,
                list2.Count);

            for (int i = 0; i < maxLenght; i++)
            {
                if (list1.Count > list2.Count && i >= list2.Count)
                {
                    for (int j = i; j < list1.Count; j++)
                    {
                        Console.Write(list1[j] + " ");
                    }
                    return;
                }
                else if (list2.Count > list1.Count && i >= list1.Count)
                {
                    for (int j = i; j < list2.Count; j++)
                    {
                        Console.Write(list2[j] + " ");
                    }
                    return;
                }
                else
                {
                    Console.Write(list1[i] + " ");
                    Console.Write(list2[i] + " ");
                }
            }
        }
    }
}