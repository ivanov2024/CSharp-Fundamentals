namespace List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine()
                .Split().ToArray();

            bool isChanged = false;

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add":
                        list.Add(int.Parse(command[1])); isChanged = true; break;
                    case "Remove":
                        list.Remove(int.Parse(command[1])); isChanged = true; break;
                    case "RemoveAt":
                        list.RemoveAt(int.Parse(command[1])); isChanged = true; break;
                    case "Insert":
                        list.Insert(int.Parse(command[2]),
                            int.Parse(command[1])); isChanged = true; break;
                    case "Contains":
                        if (list.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        foreach (int item in list)
                        {
                            if (item%2==0)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        foreach (int item in list)
                        {
                            if (item % 2 != 0)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        int sum = 0;
                        foreach (int item in list)
                        {
                            sum += item;
                        }

                        Console.WriteLine(sum);break;
                    case "Filter":
                        string condition = command[1];
                        int number = int.Parse(command[2]);

                        foreach (int item in list)
                        {
                            switch(condition)
                            {
                                case "<":
                                    if (item < number)
                                    {
                                        Console.Write(item + " ");
                                    }
                                    break;
                                case ">":
                                    if (item > number)
                                    {
                                        Console.Write(item + " ");
                                    }
                                    break;
                                case ">=":
                                    if (item >= number)
                                    {
                                        Console.Write(item + " ");
                                    }
                                    break;
                                case "=<":
                                    if (item <= number)
                                    {
                                        Console.Write(item + " ");
                                    }
                                    break;
                            }
                        }
                        Console.WriteLine();
                        break;
                }
                command = Console.ReadLine()
                .Split().ToArray();
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}