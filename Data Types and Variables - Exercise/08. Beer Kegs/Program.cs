namespace Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKeg = String.Empty;
            double biggestKegVolume = 0; 

            for (int i = 0; i < n; i++)
            {
                string modelName = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * (Math.Pow(radius, 2)) * height;

                if (volume > biggestKegVolume)
                {
                    biggestKeg = modelName;
                    biggestKegVolume = volume;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}