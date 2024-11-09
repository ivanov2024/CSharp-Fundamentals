namespace Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = Console.ReadLine().
            //    Split().Select(int.Parse).ToList();

            //List<int> bomb = Console.ReadLine().
            //    Split().Select(int.Parse).ToList();

            //int sum = 0;
            //int bombNumber = bomb[0];
            //int power = bomb[1];

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] == bombNumber)
            //    {
            //        if (i - power > 0 && i + power < list.Count)
            //        {
            //            list.RemoveRange(i - power, power);
            //            list.RemoveRange(i, power);
            //            list.Remove(bombNumber);
            //        }
            //        else if (i - power > 0 && i + power > list.Count - 1)
            //        {
            //            list.RemoveRange(i - power, power);
            //            list.Remove(list[list.Count - 1]);
            //            list.Remove(bombNumber);
            //        }
            //        else
            //        {
            //            list.RemoveRange(0, power);
            //            list.RemoveRange(i, power);
            //            list.Remove(bombNumber);
            //        }
            //    }
            //}

            //for (int i = 0; i < list.Count; i++)
            //{
            //    sum += list[i];
            //}

            //Console.WriteLine(sum);

            List<int> list = Console.ReadLine().
                Split().Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine()
                .Split().Select(int.Parse).ToList();
           
            int bombNumber = bomb[0];
            int power = bomb[1];
            for (int i = 0; i < list.Count; i++)
            {
                if (bombNumber == list[i])
                {
                    int start = i - power;
                    int end = i + power;

                    if (start <0)
                    {
                        start = 0;
                    }


                    if (end >= list.Count)
                    {
                        end = list.Count;
                    }

                    int count = end - start + 1;
                    list.RemoveRange(start, count);
                    i--;
                }
            }
            int sum = 0;
            foreach (var number in list)
            {
                sum += number;
            }
            Console.WriteLine(sum);

        }
    }
}