namespace Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());

            int trashedHeadset = 0;
            int trashedMouses = 0;
            int trashedKeyboards = 0;
            int trashedDisplays = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i%2==0)
                {
                    trashedHeadset++;
                }
                
                if (i%3==0)
                {
                    trashedMouses++;
                }
                
                if (i%2==0 && i%3==0)
                {
                    trashedKeyboards++;
                    if (trashedKeyboards%2==0)
                    {
                        trashedDisplays++;
                    }
                }
            }

            double allCost = trashedHeadset * headsetPrice + trashedMouses * mousePrice + trashedKeyboards * keyboardPrice + trashedDisplays * displayPrice;

            Console.WriteLine($"Rage expenses: {allCost:f2} lv.");
        }
    }
}