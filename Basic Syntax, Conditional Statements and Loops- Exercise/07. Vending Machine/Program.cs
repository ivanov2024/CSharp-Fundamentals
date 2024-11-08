using System.Data.SqlTypes;

namespace Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0;
            double money = 0;
            double price =0;

            while (command!= "Start")
            {
                if (command != "0.1" && command != "0.2" && command != "0.5" && command != "1" && command != "2")
                {
                   Console.WriteLine($"Cannot accept {command}");
                   command = Console.ReadLine();
                    continue;
                }

                money = double.Parse(command);
                sum += money;
                command = Console.ReadLine();
            }
            if (command == "Start")
            {
                string product = Console.ReadLine();
                while (product != "End")
                {
                    if (product == "Nuts")
                    {
                        price = 2;
                    }
                    else if (product == "Water")
                    {
                        price = 0.7;
                    }
                    else if (product == "Crisps")
                    {
                        price = 1.5;
                    }
                    else if (product == "Soda")
                    {
                        price = 0.8;
                    }
                    else if (product == "Coke")
                    {
                        price = 1;
                    }

                    sum -= price;

                    if (product != "Nuts" && product != "Water" && product != "Crisps" && product != "Soda" && product != "Coke")
                    {
                        Console.WriteLine("Invalid product");

                    }
                    else if (sum < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        sum += price;
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    product = Console.ReadLine();
                }

            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}