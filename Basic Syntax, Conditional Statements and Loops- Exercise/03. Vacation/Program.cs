namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price;
            double sum;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else
                {
                    price = 10.46;
                }

                sum = people * price;

                if (people >=30)
                {
                    sum -= sum * 0.15;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else
                {
                    price = 16;
                }

                sum = people * price;

                if (people >= 100)
                {
                    sum = price * (people - 10);
                }
            }
            else
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else
                {
                    price = 22.50;
                }

                sum = people * price;

                if (people >= 10 && 20 >= people)
                {
                    sum -= sum * 0.05;
                }
            }

            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}