namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            decimal pricePerCapsule;
            int days;
            int capsulesCount;
            decimal price;
            decimal totalPrice = 0;

            for (int i = 1; i <= n; i++)
            {
                pricePerCapsule = decimal.Parse(Console.ReadLine());
                days= int.Parse(Console.ReadLine());
                capsulesCount= int.Parse(Console.ReadLine());

                price = (days * capsulesCount) * pricePerCapsule;
                totalPrice+= price;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}