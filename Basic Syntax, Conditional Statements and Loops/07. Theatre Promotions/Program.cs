namespace Theatre_Promotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            bool flag = false;

            //if (age <= 0)
            //{
            //    Console.WriteLine("Error!");
            //    flag = true;
            //}

            //if (!flag)
            //{
            //switch(day)
            //{
            //    case "Weekday": if (age >= 0 && age <= 18) price = 12; if (age > 18 && age <= 64) price = 18; if (age > 64 && age <= 122) price = 12; break;
            //    case "Weekend": if (age >= 0 && age <= 18) price = 15; if (age > 18 && age <= 64) price = 20; if (age > 64 && age <= 122) price = 15; break;
            //    case "Holiday": if (age >= 0 && age <= 18) price = 5; if (age > 18 && age <= 64) price = 12; if (age > 64 && age <= 122) price = 10; break;
            //    default: Console.WriteLine("Error!");flag = true; break;
            //}

            //}


            //if (!flag)
            //{
            //    Console.WriteLine($"{price}$");
            //}

            if (day == "Weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 12;
                }
                else if (age > 18 && age <= 64)
                {
                  price = 18;
                }
                else if (age > 64 && age <= 122)
                {
                   price = 12; 
                }
                else
                {
                    Console.WriteLine("Error!");
                    flag = true;
                }
            }
            else if (day == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 15;
                }
                else
                {
                    Console.WriteLine("Error!");
                    flag = true;
                }
            }
            else if (day == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
                else
                {
                    Console.WriteLine("Error!");
                    flag = true;
                }
            }
            else
            {
                Console.WriteLine("Error!");
                flag = true;
            }

            if (!flag)
            {
                Console.WriteLine($"{price}$");
            }
        }
    }
}