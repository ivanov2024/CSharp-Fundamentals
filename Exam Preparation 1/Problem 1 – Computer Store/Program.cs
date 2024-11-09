namespace Problem_1___Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            decimal taxes = 0;
            decimal sumWithoutTaxes = 0;

            while (command != "special" && command != "regular")
            {
                decimal prices = decimal.Parse(command);

                if (prices < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }

                sumWithoutTaxes += prices;
                taxes += prices * 0.2m;
                command = Console.ReadLine();
            }

            decimal sumWithTaxes = sumWithoutTaxes + taxes;

            if (command == "special")
            {
                sumWithTaxes -= sumWithTaxes * 0.1m;
            }

            if (sumWithTaxes == 0 )
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {sumWithoutTaxes:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {sumWithTaxes:f2}$");
        }
    }
}